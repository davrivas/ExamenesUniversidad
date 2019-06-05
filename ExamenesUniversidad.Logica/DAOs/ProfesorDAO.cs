using ExamenesUniversidad.Datos.Entidades;
using ExamenesUniversidad.Logica.DAOs.InterfacesDAO;
using ExamenesUniversidad.Logica.Utilidades;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ExamenesUniversidad.Logica.DAOs
{
    public class ProfesorDAO : DAO<Profesor>, IProfesorDAO
    {
        public ProfesorDAO() : base("Profesores")
        {
        }

        public bool ExisteProfesor(string usuario, string clave)
        {
            throw new NotImplementedException();
        }
    }
}
