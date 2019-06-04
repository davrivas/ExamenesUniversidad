using ExamenesUniversidad.Datos.DTOs;

namespace ExamenesUniversidad.Logica.DAOs.InterfacesDAO
{
    public interface IProfesorDAO : IDAO<ProfesorDTO>
    {
        bool ExisteProfesor(string usuario, string clave);
    }
}
