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
                    .Where(y => y.ExamenPregunta.ExamenId == x.Id
                    && y.EstudianteId == Sesion.EstudianteId)
                    .Count() > 0 ? "Si" : "No",
                    Codigo = x.Codigo,
                    NumeroPreguntas = x.ExamenPreguntas.Count,
                    Abierto = x.Abierto ? "Sí" : "No",
                    FechaInicio = x.FechaInicio.ToString("yyyy/MM/dd HH:mm"),
                    FechaFin = x.FechaFin.ToString("yyyy/MM/dd HH:mm"),
                    CodigoCurso = x.Curso.Codigo,
                    NombreCurso = x.Curso.Nombre,
                    NombreProfesor = $"{x.Profesor.Nombres} {x.Profesor.Apellidos}"
                }).OrderByDescending(x => x.Realizado)
                .ThenBy(x => x.Abierto)
                .ThenByDescending(x => x.FechaInicio)
                .ThenByDescending(x => x.FechaFin)
                .ToList();

            return lista;
        }
    }
}
