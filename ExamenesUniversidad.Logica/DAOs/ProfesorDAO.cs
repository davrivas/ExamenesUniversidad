using ExamenesUniversidad.Datos.Entidades;
using ExamenesUniversidad.Logica.DAOs.InterfacesDAO;
using System;

namespace ExamenesUniversidad.Logica.DAOs
{
    public class ProfesorDAO : DAO<Profesor>, IProfesorDAO
    {
        public bool ExisteProfesor(string usuario, string clave)
        {
            throw new NotImplementedException();
        }
    }
}
