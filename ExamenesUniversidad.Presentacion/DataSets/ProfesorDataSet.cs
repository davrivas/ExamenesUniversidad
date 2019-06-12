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

        public static IList<PreguntaExamenDTO> ListarPreguntasExamen(string codigo)
        {
            var examenId = new ExamenDAO().ObtenerIdPorCodigo(codigo);

            var query = new ExamenPreguntaDAO()
                .Listar()
                .Include(x => x.Pregunta)
                .Include(x => x.Examen)
                .Include(x => x.Examen.Curso)
                .Where(x => x.ExamenId == examenId)
                .OrderBy(x => x.NumeroPregunta);

            var lista = query.Select(x => new PreguntaExamenDTO
            {
                NombreCurso = x.Examen.Curso.Nombre,
                NumeroPregunta = x.NumeroPregunta,
                Consecutivo = x.Pregunta.Consecutivo,
                Enunciado = x.Pregunta.Enunciado,
                Respuesta1 = x.Pregunta.Respuesta1,
                Respuesta2 = x.Pregunta.Respuesta2,
                Respuesta3 = x.Pregunta.Respuesta3,
                Respuesta4 = x.Pregunta.Respuesta4,
                Respuesta5 = x.Pregunta.Respuesta5,
                RespuestaCorrecta = x.Pregunta.RespuestaCorrecta
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
    }
}
