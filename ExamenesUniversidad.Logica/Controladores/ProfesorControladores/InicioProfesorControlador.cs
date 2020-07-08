using System;
using System.Collections.Generic;
using System.Linq;
using ExamenesUniversidad.Datos.DTOs.ProfesorDTOs;
using ExamenesUniversidad.Logica.DataSets;

namespace ExamenesUniversidad.Logica.Controladores.ProfesorControladores
{
    public class InicioProfesorControlador
    {
        private readonly IProfesorDataSet _profesorDataSet;

        public InicioProfesorControlador()
        {
            _profesorDataSet = new ProfesorDataSet();
        }

        public IList<CursoProfesorDTO> ListarCursos()
        {
            return _profesorDataSet.ListarCursos();
        }

        public IList<ExamenProfesorDTO> ListarExamenes()
        {
            return _profesorDataSet.ListarExamenes();
        }
    }
}
