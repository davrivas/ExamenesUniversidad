using ExamenesUniversidad.Datos.Entidades;
using ExamenesUniversidad.Logica.Utilidades;
using System;
using System.Linq;

namespace ExamenesUniversidad.Logica.DAOs
{
    public interface IEstudianteRespuestaDAO : IDAO<EstudianteRespuesta>
    {
        EstudianteRespuesta ObtenerPorExamenPreguntaIdEstudiante(int examenPreguntaId, int estudianteId);
    }

    public class EstudianteRespuestaDAO : DAO<EstudianteRespuesta>, IEstudianteRespuestaDAO
    {
        public EstudianteRespuesta ObtenerPorExamenPreguntaIdEstudiante(int examenPreguntaId, int estudianteId)
        {
            try
            {
                var estudianteRespuesta = Listar()
                    .FirstOrDefault(x => x.ExamenPreguntaId == examenPreguntaId && x.EstudianteId == estudianteId);

                return estudianteRespuesta;
            }
            catch (Exception ex)
            {
                ExcepcionUtilidades.DebugWriteLineMessageBoxShowExcepcion(ex);
                return null;
            }
        }
    }
}
