using ExamenesUniversidad.Datos.Entidades;
using ExamenesUniversidad.Logica.Utilidades;
using System;
using System.Data.Entity;
using System.Linq;

namespace ExamenesUniversidad.Logica.DAOs
{
    public interface ICursoDAO : IDAO<Curso>
    {
        Curso BurcarPorCodigo(string codigo);
        int ObtenerIdPorCodigo(string codigo);
        bool ExisteCurso(string codigo);
    }

    public class CursoDAO : DAO<Curso>, ICursoDAO
    {
        public Curso BurcarPorCodigo(string codigo)
        {
            try
            {
                var curso = Listar()
                    .Where(x => x.Codigo == codigo)
                    .Include(x => x.Preguntas)
                    .FirstOrDefault();

                return curso;
            }
            catch (Exception ex)
            {
                ExcepcionUtilidades.DebugWriteLineMessageBoxShowExcepcion(ex);
                return null;
            }
        }

        public bool ExisteCurso(string codigo)
        {
            try
            {
                var curso = Listar()
                    .Where(x => x.Codigo == codigo)
                    .FirstOrDefault();
                bool validacion = curso != null;

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
                var curso = Listar().Where(x => x.Codigo == codigo).Select(x => x.Id).FirstOrDefault();
                return curso;
            }
            catch (Exception ex)
            {
                ExcepcionUtilidades.DebugWriteLineMessageBoxShowExcepcion(ex);
                return 0;
            }
        }
    }
}
