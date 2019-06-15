using ExamenesUniversidad.Datos.DTOs.ProfesorDTOs;
using ExamenesUniversidad.Logica.DAOs;
using ExamenesUniversidad.Logica.Utilidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace ExamenesUniversidad.Presentacion.DataSets
{
    public static class ProfesorDataSet
    {
        public static IList<CursoProfesorDTO> ListarCursos()
        {
            var query = new CursoDAO()
                .Listar()
                .OrderBy(x => x.Nombre)
                .Include(x => x.Examenes)
                .Include(x => x.Preguntas)
                .AsQueryable();

            var lista = query.Select(x => new CursoProfesorDTO
            {
                Codigo = x.Codigo,
                Nombre = x.Nombre,
                CantidadPreguntas = x.Preguntas.Count,
                CantidadExamenes = x.Examenes.Count
            }).ToList();

            return lista;
        }

        public static IList<PreguntaCursoDTO> ListarPreguntasCurso(string codigo)
        {
            var query = new PreguntaDAO()
                .Listar()
                .Include(x => x.Curso)
                .Where(x => x.Curso.Codigo == codigo);

            var lista = query.Select(x => new PreguntaCursoDTO
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

        public static IList<PreguntaCursoDTO> ListarPreguntasCursoPorExamen(string codigoExamen)
        {
            int cursoId = new ExamenDAO().ObtenerIdCursoPorCodigo(codigoExamen);

            var query = new PreguntaDAO()
                .Listar()
                .Include(x => x.Curso)
                .Where(x => x.Curso.Id == cursoId);

            var lista = query.Select(x => new PreguntaCursoDTO
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

        public static IList<ExamenProfesorDTO> ListarExamenes()
        {
            var lista = new ExamenDAO()
                .Listar()
                .Where(x => x.ProfesorId == Sesion.ProfesorId)
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

        public static IList<ExamenResultadoDTO> ListarResultadosPorExamen(string codigoExamen)
        {
            var examen = new ExamenDAO().Listar()
                .Include(x => x.Curso)
                .Where(x => x.Codigo == codigoExamen && x.ProfesorId == Sesion.ProfesorId)
                .FirstOrDefault();

            var lista = new List<ExamenResultadoDTO>();

            var estudiantesRespuestas = new EstudianteRespuestaDAO()
                .Listar()
                .Include(x => x.Estudiante)
                .Include(x => x.ExamenPregunta)
                .Include(x => x.ExamenPregunta.Examen)
                .Where(x => x.ExamenPregunta.Examen.Codigo == codigoExamen && x.ExamenPregunta.Examen.ProfesorId == Sesion.ProfesorId);

            var agrupamiento = estudiantesRespuestas.GroupBy(x => x.Estudiante).ToList();

            var examenRespuestaDAO = new EstudianteRespuestaDAO();

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
