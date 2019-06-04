using ExamenesUniversidad.Datos.Conexiones;
using ExamenesUniversidad.Datos.DTOs.DTOBases;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ExamenesUniversidad.Logica.DAOs
{
    public class DAO<T> where T : DTOBase
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

        public void Eliminar(int id)
        {
            try
            {
                Conexion.Abrir();
                _sql = $"DELETE FROM {_nombreTabla} " +
                    $"WHERE Id = {id.ToString()}";
                _comando = new SqlCommand(_sql, Conexion.ConexionObj);
                _cont = _comando.ExecuteNonQuery();

                if (_cont == 1)
                    MessageBox.Show("Se eliminó el registro", "Exito");
                else
                    MessageBox.Show("No se pudo eliminar el registro", "Error");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("No se pudo eliminar el registro\n"
                    + "Mensaje: " + ex.Message, "Error");
            }
            finally
            {
                Conexion.Cerrar();
            }
        }

        public virtual void Ingresar(T obj)
        {
        }
    }
}
