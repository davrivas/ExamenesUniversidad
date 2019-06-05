using ExamenesUniversidad.Datos.DTOs;

namespace ExamenesUniversidad.Logica.DAOs.InterfacesDAO
{
    public interface ICursoDAO : IDAO<CursoDTO>
    {
        bool ExisteCursoCodigo(string codigo);
    }
}
