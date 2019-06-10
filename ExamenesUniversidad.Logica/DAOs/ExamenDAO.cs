using ExamenesUniversidad.Datos.Entidades;
using ExamenesUniversidad.Logica.Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenesUniversidad.Logica.DAOs
{
    public interface IExamenDAO : IDAO<Examen>
    {
        bool ExisteExamen(string codigo);
    }

    public class ExamenDAO : DAO<Examen>, IExamenDAO
    {
        public bool ExisteExamen(string codigo)
        {
            try
            {
                var examen = Listar()
                    .Where(x => x.Codigo == codigo)
                    .FirstOrDefault();
                bool validacion = examen != null;

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
