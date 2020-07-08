using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamenesUniversidad.Datos.DTOs.ProfesorDTOs;
using ExamenesUniversidad.Logica.DataSets;

namespace ExamenesUniversidad.Logica.Controladores.ProfesorControladores
{
    public class VerPreguntasCursoControlador
    {
        private readonly IProfesorDataSet _profesorDataSet;

        public VerPreguntasCursoControlador()
        {
            _profesorDataSet = new ProfesorDataSet();
        }

        public IList<PreguntaCursoDTO> ListarPreguntasCurso(string codigo)
        {
            return _profesorDataSet.ListarPreguntasCurso(codigo);
        }
    }
}
