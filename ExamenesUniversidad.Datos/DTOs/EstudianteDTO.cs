namespace ExamenesUniversidad.Datos.DTOs
{
    public class EstudianteDTO : UsuarioDTO
    {
        public int NumeroCarnet { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
    }
}
