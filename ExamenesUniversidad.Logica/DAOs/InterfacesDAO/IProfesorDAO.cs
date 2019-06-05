using ExamenesUniversidad.Datos.Entidades;

namespace ExamenesUniversidad.Logica.DAOs.InterfacesDAO
{
    public interface IProfesorDAO : IDAO<Profesor>
    {
        bool ExisteProfesor(string usuario, string clave);
    }
}
