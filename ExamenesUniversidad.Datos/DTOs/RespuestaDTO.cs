namespace ExamenesUniversidad.Datos.DTOs
{
    public class RespuestaDTO : DTOBase
    {
        public int NumeroRespuesta { get; set; }
        public string Texto { get; set; }
        public short Valida { get; set; }

        public int PreguntaId { get; set; }
        public PreguntaDTO Pregunta { get; set; }
    }
}
