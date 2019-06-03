namespace ExamenesUniversidad.Datos.DTOs
{
    public abstract class UsuarioDTO : DTOBase
    {
        public string Usuario { get; set; }
        public string Clave { get; set; }
    }
}
