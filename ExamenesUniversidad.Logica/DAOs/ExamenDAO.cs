using ExamenesUniversidad.Datos.Entidades;
using ExamenesUniversidad.Logica.Utilidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenesUniversidad.Logica.DAOs
{
    public interface IExamenDAO : IDAO<Examen>
    {
        bool ExisteExamen(string codigo);
        Examen ObtenerPorCodigo(string codigo);
        int ObtenerIdPorCodigo(string codigo);
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

        public int ObtenerIdPorCodigo(string codigo)
        {
            try
            {
                var examenId = Listar()
                    .Where(x => x.Codigo == codigo)
                    .Select(x => x.Id)
                    .FirstOrDefault();

                return examenId;
            }
            catch (Exception ex)
            {
                ExcepcionUtilidades.DebugWriteLineMessageBoxShowExcepcion(ex);
                return 0;
            }
        }

        public Examen ObtenerPorCodigo(string codigo)
        {
            try
            {
                var examen = Listar()
                    .Where(x => x.Codigo == codigo)
                    .Include(x => x.ExamenPreguntas)
                    .FirstOrDefault();

                return examen;
            }
            catch (Exception ex)
            {
                ExcepcionUtilidades.DebugWriteLineMessageBoxShowExcepcion(ex);
                return null;
            }
        }
    }
}
