using ExamenesUniversidad.Datos.Entidades;
using ExamenesUniversidad.Logica.Utilidades;
using System;
using System.Data.Entity;
using System.Linq;

namespace ExamenesUniversidad.Logica.DAOs
{
    public interface IExamenDAO : IDAO<Examen>
    {
        bool ExisteExamen(string codigo);
        Examen ObtenerPorCodigo(string codigo);
        int ObtenerIdPorCodigo(string codigo);
        int ObtenerIdCursoPorCodigo(string codigo);
    }

    public class ExamenDAO : DAO<Examen>, IExamenDAO
    {
        public bool ExisteExamen(string codigo)
        {
            try
            {
                var examen = Listar()
                    .FirstOrDefault(x => x.Codigo == codigo);
                bool validacion = examen != null;

                return validacion;
            }
            catch (Exception ex)
            {
                ExcepcionUtilidades.DebugWriteLineMessageBoxShowExcepcion(ex);
                return false;
            }
        }

        public int ObtenerIdCursoPorCodigo(string codigo)
        {
            try
            {
                var cursoId = Listar()
                    .Include(x => x.Curso)
                    .Where(x => x.Codigo == codigo)
                    .Select(x => x.Curso.Id)
                    .FirstOrDefault();

                return cursoId;
            }
            catch (Exception ex)
            {
                ExcepcionUtilidades.DebugWriteLineMessageBoxShowExcepcion(ex);
                return 0;
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
                    .Include("ExamenPreguntas.Pregunta")
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
