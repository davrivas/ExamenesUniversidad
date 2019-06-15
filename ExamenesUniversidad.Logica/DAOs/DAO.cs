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
        void Ingresar(T registro);
        void Editar(T antiguoRegistro, T nuevoRegistro);
        void Eliminar(T registro);
        T BuscarPorId(int id);
        IQueryable<T> Listar();
    }

    public abstract class DAO<T> : IDAO<T> where T : EntidadBase
    {
        protected readonly ExamenesUniversidadContext Context;

        public DAO()
        {
            Context = new ExamenesUniversidadContext();
        }

        public virtual T BuscarPorId(int id)
        {
            try
            {
                var objeto = Context.Set<T>().Find(id);
                return objeto;
            }
            catch (Exception ex)
            {
                ExcepcionUtilidades.DebugWriteLineMessageBoxShowExcepcion(ex);
                return null;
            }
        }

        public virtual void Editar(T antiguoRegistro, T nuevoRegistro)
        {
            try
            {
                Context.Entry(antiguoRegistro).CurrentValues.SetValues(nuevoRegistro);
                Context.SaveChanges();
            }
            catch (Exception ex)
            {
                ExcepcionUtilidades.DebugWriteLineMessageBoxShowExcepcion(ex);
            }
        }

        public virtual void Eliminar(T registro)
        {
            try
            {
                Context.Set<T>().Remove(registro);
                Context.SaveChanges();
            }
            catch (Exception ex)
            {
                ExcepcionUtilidades.DebugWriteLineMessageBoxShowExcepcion(ex);
            }
        }

        public virtual void Ingresar(T registro)
        {
            try
            {
                Context.Set<T>().Add(registro);
                Context.SaveChanges();
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
                var lista = Context.Set<T>().AsQueryable();
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
