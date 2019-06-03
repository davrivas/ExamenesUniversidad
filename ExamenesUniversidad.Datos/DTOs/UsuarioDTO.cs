namespace ExamenesUniversidad.Datos.DTOs
{
    public abstract class UsuarioDTO : DTOBase
    {
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Usuario { get; set; }
        public string Clave { get; set; }
    }
}
