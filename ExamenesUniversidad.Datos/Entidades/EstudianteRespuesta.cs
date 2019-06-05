namespace ExamenesUniversidad.Datos.Entidades
{
    public class EstudianteRespuesta : EntidadBase
    {
        public int Respuesta { get; set; }

        public int EstudianteId { get; set; }
        public Estudiante Estudiante { get; set; }
        public int ExamenPreguntaId { get; set; }
        public ExamenPregunta ExamenPregunta { get; set; }
    }
}
