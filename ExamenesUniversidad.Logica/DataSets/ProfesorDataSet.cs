using ExamenesUniversidad.Datos.DTOs.ProfesorDTOs;
using ExamenesUniversidad.Logica.DAOs;
using ExamenesUniversidad.Logica.Utilidades;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace ExamenesUniversidad.Logica.DataSets
{
    public interface IProfesorDataSet
    {
        IList<CursoProfesorDTO> ListarCursos();
        IList<PreguntaCursoDTO> ListarPreguntasCurso(string codigo);
        IList<PreguntaCursoDTO> ListarPreguntasCursoPorExamen(string codigoExamen);
        IList<ExamenProfesorDTO> ListarExamenes();
        IList<ExamenResultadoDTO> ListarResultadosPorExamen(string codigoExamen);
    }

    public class ProfesorDataSet : IProfesorDataSet
    {
        private readonly ICursoDAO _cursoDAO;
        private readonly IEstudianteRespuestaDAO _estudianteRespuestaDAO;
        private readonly IExamenDAO _examenDao;
        private readonly IPreguntaDAO _preguntaDAO;

        public ProfesorDataSet()
        {
            _cursoDAO = new CursoDAO();
            _estudianteRespuestaDAO = new EstudianteRespuestaDAO();
            _examenDao = new ExamenDAO();
            _preguntaDAO = new PreguntaDAO();
        }

        public IList<CursoProfesorDTO> ListarCursos()
        {
            var lista = _cursoDAO
                .Listar()
                .OrderBy(x => x.Nombre)
                .Include(x => x.Examenes)
                .Include(x => x.Preguntas)
                .Select(x => new CursoProfesorDTO
                {
                    Codigo = x.Codigo,
                    Nombre = x.Nombre,
                    CantidadPreguntas = x.Preguntas.Count,
                    CantidadExamenes = x.Examenes.Count
                }).ToList();

            return lista;
        }

        public IList<PreguntaCursoDTO> ListarPreguntasCurso(string codigo)
        {
            var lista = _preguntaDAO
                .Listar()
                .Include(x => x.Curso)
                .Where(x => x.Curso.Codigo == codigo)
                .Select(x => new PreguntaCursoDTO
                {
                    NombreCurso = x.Curso.Nombre,
                    Consecutivo = x.Consecutivo,
                    Enunciado = x.Enunciado,
                    Respuesta1 = x.Respuesta1,
                    Respuesta2 = x.Respuesta2,
                    Respuesta3 = x.Respuesta3,
                    Respuesta4 = x.Respuesta4,
                    Respuesta5 = x.Respuesta5,
                    RespuestaCorrecta = x.RespuestaCorrecta
                }).ToList();

            return lista;
        }

        public IList<PreguntaCursoDTO> ListarPreguntasCursoPorExamen(string codigoExamen)
        {
            int cursoId = _examenDao
                .ObtenerIdCursoPorCodigo(codigoExamen);

            var lista = _preguntaDAO
                .Listar()
                .Include(x => x.Curso)
                .Where(x => x.Curso.Id == cursoId)
                .Select(x => new PreguntaCursoDTO
                {
                    NombreCurso = x.Curso.Nombre,
                    Consecutivo = x.Consecutivo,
                    Enunciado = x.Enunciado,
                    Respuesta1 = x.Respuesta1,
                    Respuesta2 = x.Respuesta2,
                    Respuesta3 = x.Respuesta3,
                    Respuesta4 = x.Respuesta4,
                    Respuesta5 = x.Respuesta5,
                    RespuestaCorrecta = x.RespuestaCorrecta
                }).ToList();

            return lista;
        }

        public IList<ExamenProfesorDTO> ListarExamenes()
        {
            var lista = _examenDao
                .Listar()
                .Where(x => x.ProfesorId == Sesion.Profesor.Id)
                .OrderBy(x => x.Abierto)
                .ThenByDescending(x => x.FechaInicio)
                .ThenByDescending(x => x.FechaFin)
                .Include(x => x.Profesor)
                .Include(x => x.Curso)
                .Include(x => x.ExamenPreguntas)
                .ToList()
                .Select(x => new ExamenProfesorDTO
                {
                    Codigo = x.Codigo,
                    NumeroPreguntas = x.ExamenPreguntas.Count,
                    Abierto = x.Abierto ? "Sí" : "No",
                    FechaInicio = x.FechaInicio.ToString("yyyy/MM/dd HH:mm"),
                    FechaFin = x.FechaFin.ToString("yyyy/MM/dd HH:mm"),
                    CodigoCurso = x.Curso.Codigo,
                    NombreCurso = x.Curso.Nombre,
                    NombreProfesor = $"{x.Profesor.Nombres} {x.Profesor.Apellidos}"
                }).ToList();

            return lista;
        }

        public IList<ExamenResultadoDTO> ListarResultadosPorExamen(string codigoExamen)
        {
            var examen = _examenDao
                .Listar()
                .Include(x => x.Curso)
                .FirstOrDefault(x => x.Codigo == codigoExamen && x.ProfesorId == Sesion.Profesor.Id);

            var lista = new List<ExamenResultadoDTO>();

            var estudiantesRespuestas = _estudianteRespuestaDAO
                .Listar()
                .Include(x => x.Estudiante)
                .Include(x => x.ExamenPregunta)
                .Include(x => x.ExamenPregunta.Examen)
                .Where(x => x.ExamenPregunta.Examen.Codigo == codigoExamen && x.ExamenPregunta.Examen.ProfesorId == Sesion.Profesor.Id);

            var agrupamiento = estudiantesRespuestas.GroupBy(x => x.Estudiante).ToList();

            foreach (var estudiante in agrupamiento)
            {
                var respuestas = estudiantesRespuestas
                    .Where(x => x.EstudianteId == estudiante.Key.Id);

                var resultado = new ExamenResultadoDTO
                {
                    CodigoExamen = codigoExamen,
                    NombreCurso = examen.Curso.Nombre,
                    NombreEstudiante = $"{estudiante.Key.Nombres} {estudiante.Key.Apellidos}",
                    NumeroCarnet = estudiante.Key.NumeroCarnet,
                    CantidadBien = respuestas.Count(x => x.Correcta),
                    CantidadMal = respuestas.Count(x => !x.Correcta),
                    TotalPreguntas = respuestas.Count()
                };
                lista.Add(resultado);
            }

            return lista.OrderBy(x => x.NombreEstudiante).ToList();
        }
    }
}
