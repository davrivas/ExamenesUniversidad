using ExamenesUniversidad.Datos.DTOs.ProfesorDTOs;
using ExamenesUniversidad.Logica.DataSets;
using System.Collections.Generic;

namespace ExamenesUniversidad.Logica.Controladores.ProfesorControladores
{
    public class CalificacionesExamenControlador
    {
        private readonly IProfesorDataSet _profesorDataSet;

        public CalificacionesExamenControlador()
        {
            _profesorDataSet = new ProfesorDataSet();
        }

        public IList<ExamenResultadoDTO> ListarResultadosPorExamen(string codigoExamen)
        {
            return _profesorDataSet.ListarResultadosPorExamen(codigoExamen);
        }
    }
}
