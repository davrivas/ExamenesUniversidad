using ExamenesUniversidad.Datos.Entidades;

namespace ExamenesUniversidad.Logica.DAOs.InterfacesDAO
{
    public interface ICursoDAO : IDAO<Curso>
    {
        bool ExisteCursoCodigo(string codigo);
    }
}
