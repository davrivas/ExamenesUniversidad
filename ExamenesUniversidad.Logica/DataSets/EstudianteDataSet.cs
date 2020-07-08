using ExamenesUniversidad.Datos.DTOs.EstudianteDTOs;
using ExamenesUniversidad.Logica.DAOs;
using ExamenesUniversidad.Logica.Utilidades;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace ExamenesUniversidad.Logica.DataSets
{
    public interface IEstudianteDataSet
    {
        IList<ExamenEstudianteDTO> GetExamenes();
        IList<EstudianteResultadoDTO> ListarResultados();
    }

    public class EstudianteDataSet : IEstudianteDataSet
    {
        private readonly ICursoDAO _cursoDAO;
        private readonly IEstudianteRespuestaDAO _estudianteRespuestaDAO;
        private readonly IExamenDAO _examenDAO;
        private readonly IProfesorDAO _profesorDAO;

        public EstudianteDataSet()
        {
            _cursoDAO = new CursoDAO();
            _estudianteRespuestaDAO = new EstudianteRespuestaDAO();
            _examenDAO = new ExamenDAO();
            _profesorDAO = new ProfesorDAO();
        }

        public IList<ExamenEstudianteDTO> GetExamenes()
        {
            var lista = _examenDAO
                .Listar()
                .Include(x => x.Profesor)
                .Include(x => x.Curso)
                .Include(x => x.ExamenPreguntas)
                .ToList()
                .Select(x => new ExamenEstudianteDTO
                {
                    Realizado = _estudianteRespuestaDAO.Listar()
                        .Include(y => y.ExamenPregunta)
                        .Count(y => y.ExamenPregunta.ExamenId == x.Id && y.EstudianteId == Sesion.Estudiante.Id) > 0 ? "Sí" : "No",
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

        public IList<EstudianteResultadoDTO> ListarResultados()
        {
            var lista = new List<EstudianteResultadoDTO>();

            var respuestas = _estudianteRespuestaDAO
                .Listar()
                .Include(x => x.Estudiante)
                .Include(x => x.ExamenPregunta)
                .Include(x => x.ExamenPregunta.Examen)
                .Include(x => x.ExamenPregunta.Examen.Curso)
                .Include(x => x.ExamenPregunta.Examen.Profesor)
                .Where(x => x.EstudianteId == Sesion.Estudiante.Id);

            var agrupamiento = respuestas.GroupBy(x => x.ExamenPregunta.Examen).ToList();

            foreach (var examen in agrupamiento)
            {
                var profesor = _profesorDAO.BuscarPorId(examen.Key.ProfesorId);
                var curso = _cursoDAO.BuscarPorId(examen.Key.CursoId);
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
