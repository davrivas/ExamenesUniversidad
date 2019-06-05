namespace ExamenesUniversidad.Datos.Entidades
{
    public abstract class Usuario : EntidadBase
    {
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string NombreUsuario { get; set; }
        public string Clave { get; set; }
    }
}
