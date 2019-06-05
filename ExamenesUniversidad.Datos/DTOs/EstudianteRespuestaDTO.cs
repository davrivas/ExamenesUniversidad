using ExamenesUniversidad.Datos.DTOs.DTOBases;

namespace ExamenesUniversidad.Datos.DTOs
{
    public class EstudianteRespuestaDTO : DTOBase
    {
        public int Respuesta { get; set; }

        public int EstudianteId { get; set; }
        public EstudianteDTO Estudiante { get; set; }
        public int ExamenPreguntaId { get; set; }
        public ExamenPreguntaDTO ExamenPregunta { get; set; }
    }
}
