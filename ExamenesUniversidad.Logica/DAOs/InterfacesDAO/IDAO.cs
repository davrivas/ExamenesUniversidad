namespace ExamenesUniversidad.Logica.DAOs.InterfacesDAO
{
    public interface IDAO<T>
    {
        void Ingresar(T obj);
        void Editar(T obj);
        void Eliminar(T obj);
        T BuscarPorId(int id);
    }
}
