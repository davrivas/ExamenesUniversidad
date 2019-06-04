using ExamenesUniversidad.Datos.DTOs;

namespace ExamenesUniversidad.Logica.DAOs.InterfacesDAO
{
    public interface IEstudianteDAO : IDAO<EstudianteDTO>
    {
        bool ExisteEstudiante(string usuario, string clave);
    }
}
