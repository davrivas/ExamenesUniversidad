namespace ExamenesUniversidad.Logica.DAOs.InterfacesDAO
{
    public interface IDAO<T>
    {
        void Ingresar(T obj);
        void Editar(T obj);
        void Eliminar(int id);
        T BuscarPorId(int id);
    }
}
