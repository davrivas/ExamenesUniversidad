using ExamenesUniversidad.Datos.Conexiones;
using ExamenesUniversidad.Datos.DTOs;
using ExamenesUniversidad.Logica.DAOs.InterfacesDAO;
using ExamenesUniversidad.Logica.Utilidades;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ExamenesUniversidad.Logica.DAOs
{
    public class EstudianteDAO : DAO<EstudianteDTO>, IEstudianteDAO
    {
        public EstudianteDAO() : base("Estudiantes")
        {
        }

        public bool ExisteEstudiante(string usuario, string clave)
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
                    Sesion.EstudianteId = (int)_lector["Id"];
                }

                Conexion.Cerrar();

                return _existe;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Conexion.Cerrar();
                MessageBox.Show("No se pudo conseguir información del estudiante\n"
                    + "Mensaje: " + ex.Message, "Error");
                return _existe;
            }
        }
    }
}
