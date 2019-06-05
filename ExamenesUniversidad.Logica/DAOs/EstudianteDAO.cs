using ExamenesUniversidad.Datos.Entidades;
using ExamenesUniversidad.Logica.DAOs.InterfacesDAO;
using System;

namespace ExamenesUniversidad.Logica.DAOs
{
    public class EstudianteDAO : DAO<Estudiante>, IEstudianteDAO
    {
        public bool ExisteEstudiante(string usuario, string clave)
        {
            throw new NotImplementedException();
        }
    }
}
