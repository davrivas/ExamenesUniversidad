using ExamenesUniversidad.Datos.Entidades;
using System;
using System.Linq;

namespace ExamenesUniversidad.Logica.DAOs
{
    public class DAO<T> where T : EntidadBase
    {
        public virtual T BuscarPorId(int id)
        {
            throw new NotImplementedException();
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

        public virtual IQueryable<T> ObtenerTodos()
        {
            throw new NotImplementedException();
        }
    }
}
