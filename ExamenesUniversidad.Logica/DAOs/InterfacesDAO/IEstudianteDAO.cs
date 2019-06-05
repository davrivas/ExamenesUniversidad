using ExamenesUniversidad.Datos.Entidades;

namespace ExamenesUniversidad.Logica.DAOs.InterfacesDAO
{
    public interface IEstudianteDAO : IDAO<Estudiante>
    {
        bool ExisteEstudiante(string usuario, string clave);
    }
}
