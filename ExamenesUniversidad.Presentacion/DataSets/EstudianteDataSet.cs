using ExamenesUniversidad.Datos.DTOs.EstudianteDTOs;
using ExamenesUniversidad.Logica.DAOs;
using ExamenesUniversidad.Logica.Utilidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenesUniversidad.Presentacion.DataSets
{
    public static class EstudianteDataSet
    {
        public static IList<ExamenEstudianteDTO> GetExamenes()
        {
            var estudianteRespuestaDAO = new EstudianteRespuestaDAO();

            var lista = new ExamenDAO()
                .Listar()
                .Include(x => x.Profesor)
                .Include(x => x.Curso)
                .Include(x => x.ExamenPreguntas)
                .ToList()
                .Select(x => new ExamenEstudianteDTO
                {
                    Realizado = estudianteRespuestaDAO.Listar()
                    .Include(y => y.ExamenPregunta)
                    .Where(y => y.ExamenPregunta.ExamenId == x.Id && y.EstudianteId == Sesion.EstudianteId)
                    .Count() > 0 ? "Sí" : "No",
                    Codigo = x.Codigo,
                    NumeroPreguntas = x.ExamenPreguntas.Count,
                    Abierto = x.Abierto ? "Sí" : "No",
                    FechaInicio = x.FechaInicio.ToString("yyyy/MM/dd HH:mm"),
                    FechaFin = x.FechaFin.ToString("yyyy/MM/dd HH:mm"),
                    CodigoCurso = x.Curso.Codigo,
                    NombreCurso = x.Curso.Nombre,
                    NombreProfesor = $"{x.Profesor.Nombres} {x.Profesor.Apellidos}"
                }).OrderBy(x => x.Realizado)
                .ThenBy(x => x.Abierto)
                .ThenByDescending(x => x.FechaInicio)
                .ThenByDescending(x => x.FechaFin)
                .ToList();

            return lista;
        }

        public static IList<EstudianteResultadoDTO> ListarResultados()
        {
            var lista = new List<EstudianteResultadoDTO>();

            var respuestas = new EstudianteRespuestaDAO()
                .Listar()
                .Include(x => x.Estudiante)
                .Include(x => x.ExamenPregunta)
                .Include(x => x.ExamenPregunta.Examen)
                .Include(x => x.ExamenPregunta.Examen.Curso)
                .Include(x => x.ExamenPregunta.Examen.Profesor)
                .Where(x => x.EstudianteId == Sesion.EstudianteId);

            var agrupamiento = respuestas.GroupBy(x => x.ExamenPregunta.Examen).ToList();

            var profesorDAO = new ProfesorDAO();
            var cursoDAO = new CursoDAO();

            foreach (var examen in agrupamiento)
            {
                var profesor = profesorDAO.BuscarPorId(examen.Key.ProfesorId);
                var curso = cursoDAO.BuscarPorId(examen.Key.CursoId);
                var respuestasPorExamen = respuestas
                    .Where(x => x.ExamenPregunta.ExamenId == examen.Key.Id);

                var resultado = new EstudianteResultadoDTO
                {
                    CodigoExamen = examen.Key.Codigo,
                    NombreCurso = curso.Nombre,
                    NombreProfesor = $"{profesor.Nombres} {profesor.Apellidos}",
                    CantidadBien = respuestasPorExamen.Count(x => x.Correcta),
                    CantidadMal = respuestasPorExamen.Count(x => !x.Correcta),
                    TotalPreguntas = respuestasPorExamen.Count()
                };

                lista.Add(resultado);
            }

            return lista
                .OrderBy(x => x.NombreProfesor)
                .ThenBy(x => x.NombreCurso)
                .ToList();
        }
    }
}
