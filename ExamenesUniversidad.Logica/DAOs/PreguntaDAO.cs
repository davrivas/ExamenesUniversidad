using ExamenesUniversidad.Datos.Entidades;
using ExamenesUniversidad.Logica.Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenesUniversidad.Logica.DAOs
{
    public interface IPreguntaDAO : IDAO<Pregunta>
    {
        bool ExistePregunta(string codigo);
        int ObtenerIdPorCodigo(string codigo);
    }

    public class PreguntaDAO : DAO<Pregunta>, IPreguntaDAO
    {
        public bool ExistePregunta(string codigo)
        {
            try
            {
                var pregunta = Listar()
                    .FirstOrDefault(x => x.Consecutivo == codigo);
                bool validacion = pregunta != null;

                return validacion;
            }
            catch (Exception ex)
            {
                ExcepcionUtilidades.DebugWriteLineMessageBoxShowExcepcion(ex);
                return false;
            }
        }

        public int ObtenerIdPorCodigo(string codigo)
        {
            try
            {
                var preguntaId = Listar()
                    .Where(x => x.Consecutivo == codigo)
                    .Select(x => x.Id)
                    .FirstOrDefault();

                return preguntaId;
            }
            catch (Exception ex)
            {
                ExcepcionUtilidades.DebugWriteLineMessageBoxShowExcepcion(ex);
                return 0;
            }
        }
    }
}
