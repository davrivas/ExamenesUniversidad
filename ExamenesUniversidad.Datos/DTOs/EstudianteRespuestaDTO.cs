namespace ExamenesUniversidad.Datos.DTOs
{
    public class EstudianteRespuestaDTO : DTOBase
    {
        public int EstudianteId { get; set; }
        public EstudianteDTO Estudiante { get; set; }
        public int RespuestaId { get; set; }
        public RespuestaDTO Respuesta { get; set; }
    }
}
