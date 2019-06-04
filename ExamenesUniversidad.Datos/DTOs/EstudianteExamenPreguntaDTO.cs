using ExamenesUniversidad.Datos.DTOs.DTOBases;

namespace ExamenesUniversidad.Datos.DTOs
{
    public class EstudianteExamenPreguntaDTO : DTOBase
    {
        public int Respuesta { get; set; }

        public int EstudianteId { get; set; }
        public EstudianteDTO Estudiante { get; set; }
        public int PreguntaExamenId { get; set; }
        public ExamenPreguntaDTO PreguntaExamen { get; set; }
    }
}
