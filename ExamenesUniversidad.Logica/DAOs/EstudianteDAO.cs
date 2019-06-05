using ExamenesUniversidad.Datos.Entidades;
using ExamenesUniversidad.Logica.DAOs.InterfacesDAO;
using ExamenesUniversidad.Logica.Utilidades;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ExamenesUniversidad.Logica.DAOs
{
    public class EstudianteDAO : DAO<Estudiante>, IEstudianteDAO
    {
        public EstudianteDAO() : base("Estudiantes")
        {
        }

        public bool ExisteEstudiante(string usuario, string clave)
        {
            throw new NotImplementedException();
        }
    }
}
