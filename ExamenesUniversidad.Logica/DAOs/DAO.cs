using ExamenesUniversidad.Datos.DbContexts;
using ExamenesUniversidad.Datos.Entidades;
using ExamenesUniversidad.Logica.Utilidades;
using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace ExamenesUniversidad.Logica.DAOs
{
    public interface IDAO<T>
    {
        void Ingresar(T obj);
        void Editar(T obj);
        void Eliminar(T obj);
        T BuscarPorId(int id);
        IQueryable<T> Listar();
    }

    public abstract class DAO<T> : IDAO<T> where T : EntidadBase
    {
        protected readonly ExamenesUniversidadContext _context;

        public DAO()
        {
            _context = new ExamenesUniversidadContext();
        }

        public virtual T BuscarPorId(int id)
        {
            try
            {
                var objeto = _context.Set<T>().Find(id);
                return objeto;
            }
            catch (Exception ex)
            {
                ExcepcionUtilidades.DebugWriteLineMessageBoxShowExcepcion(ex);
                return null;
            }
        }

        public virtual void Editar(T obj)
        {
            try
            {
                _context.Entry(obj).State = EntityState.Modified;
                _context.Set<T>().Add(obj);
                _context.SaveChanges();

                MessageBox.Show("El registro fue actualizado satisfactoriamente");
            }
            catch (Exception ex)
            {
                ExcepcionUtilidades.DebugWriteLineMessageBoxShowExcepcion(ex);
            }
        }



        public virtual void Eliminar(T obj)
        {
            try
            {
                _context.Set<T>().Remove(obj);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                ExcepcionUtilidades.DebugWriteLineMessageBoxShowExcepcion(ex);
            }
        }

        public virtual void Ingresar(T obj)
        {
            try
            {
                _context.Set<T>().Add(obj);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                ExcepcionUtilidades.DebugWriteLineMessageBoxShowExcepcion(ex);
            }
        }

        public virtual IQueryable<T> Listar()
        {
            try
            {
                var lista = _context.Set<T>().AsQueryable();
                return lista;
            }
            catch (Exception ex)
            {
                ExcepcionUtilidades.DebugWriteLineMessageBoxShowExcepcion(ex);
                return null;
            }
        }
    }
}
