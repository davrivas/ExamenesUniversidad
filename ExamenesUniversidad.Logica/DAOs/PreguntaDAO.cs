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
    }

    public class PreguntaDAO : DAO<Pregunta>, IPreguntaDAO
    {
        public bool ExistePregunta(string codigo)
        {
            try
            {
                var pregunta = Listar()
                    .Where(x => x.Consecutivo == codigo)
                    .FirstOrDefault();
                bool validacion = pregunta != null;

                return validacion;
            }
            catch (Exception ex)
            {
                ExcepcionUtilidades.DebugWriteLineMessageBoxShowExcepcion(ex);
                return false;
            }
        }
    }
}
