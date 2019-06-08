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
    }
}
