using ExamenesUniversidad.Datos.Conexiones;
using ExamenesUniversidad.Datos.DTOs;
using ExamenesUniversidad.Logica.DAOs.InterfacesDAO;
using ExamenesUniversidad.Logica.Utilidades;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ExamenesUniversidad.Logica.DAOs
{
    public class ProfesorDAO : DAO<ProfesorDTO>, IProfesorDAO
    {
        public ProfesorDAO() : base("Profesores")
        {
        }

        public bool ExisteProfesor(string usuario, string clave)
        {
            _existe = false;

            try
            {
                Conexion.Abrir();
                _sql = $"SELECT TOP(1) * " +
                    $"FROM {_nombreTabla} " +
                    $"WHERE Usuario = '{usuario}' " +
                    $"AND Clave = '{clave}'";
                _comando = new SqlCommand(_sql, Conexion.ConexionObj);
                _lector = _comando.ExecuteReader();

                if (_lector.Read())
                {
                    _existe = true;
                    Sesion.ProfesorId = (int)_lector["Id"];
                }
                else
                {
                    MessageBox.Show("No se pudo conseguir información del profesor", "Error");
                }

                Conexion.Cerrar();
                return _existe;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Conexion.Cerrar();
                MessageBox.Show("No se pudo conseguir información del profesor\n"
                    + "Mensaje: " + ex.Message, "Error");
                return _existe;
            }
        }
    }
}
