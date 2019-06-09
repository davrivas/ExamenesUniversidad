using ExamenesUniversidad.Datos.DTOs;
using ExamenesUniversidad.Logica.DAOs;
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
            var cursoDAO = new CursoDAO();
            var query = cursoDAO.Listar()
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
            var preguntaDAO = new PreguntaDAO();
            var query = preguntaDAO.Listar()
                .Include(x => x.Curso)
                .Where(x => x.Curso.Codigo == codigo)
                .AsQueryable();

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
    }
}
