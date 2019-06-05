using ExamenesUniversidad.Datos.Conexiones;
using ExamenesUniversidad.Datos.DTOs;
using ExamenesUniversidad.Logica.DAOs.InterfacesDAO;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ExamenesUniversidad.Logica.DAOs
{
    public class CursoDAO : DAO<CursoDTO>, ICursoDAO
    {
        public CursoDAO() : base("Cursos")
        {
        }

        public bool ExisteCursoCodigo(string codigo)
        {
            _existe = false;

            try
            {
                Conexion.Abrir();
                _sql = $"SELECT TOP(1) * " +
                    $"FROM {_nombreTabla} " +
                    $"WHERE Codigo = '{codigo}'";
                _comando = new SqlCommand(_sql, Conexion.ConexionObj);
                _lector = _comando.ExecuteReader();

                if (_lector.Read())
                {
                    _existe = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Conexion.Cerrar();
            return _existe;
        }
    }
}
