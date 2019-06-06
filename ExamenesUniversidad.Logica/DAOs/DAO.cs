using ExamenesUniversidad.Datos.DbContexts;
using ExamenesUniversidad.Datos.Entidades;
using System;
using System.Linq;

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
            var objeto = _context.Set<T>().Find(id);
            return objeto;
        }

        public virtual void Editar(T obj)
        {
        }

        public virtual void Eliminar(T obj)
        {
        }

        public virtual void Ingresar(T obj)
        {
        }

        public virtual IQueryable<T> Listar()
        {
            var lista = _context.Set<T>().AsQueryable();
            return lista;
        }
    }
}
