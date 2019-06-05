using ExamenesUniversidad.Datos.Entidades;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ExamenesUniversidad.Logica.DAOs
{
    public class DAO<T> where T : EntidadBase
    {
        protected string _nombreTabla;
        protected string _sql;
        protected SqlCommand _comando;
        protected SqlDataReader _lector;
        protected bool _existe;
        protected int _cont;

        public DAO(string nombreTabla)
        {
            _nombreTabla = nombreTabla;
        }

        public virtual T BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public virtual void Editar(T obj)
        {
        }

        public virtual void Eliminar(int id)
        {
        }

        public virtual void Ingresar(T obj)
        {
        }
    }
}
