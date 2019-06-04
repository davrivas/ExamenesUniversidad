using ExamenesUniversidad.Datos.DTOs.DTOBases;

namespace ExamenesUniversidad.Datos.DTOs
{
    public class EstudiantePreguntaExamenDTO : DTOBase
    {
        public int Respuesta { get; set; }

        public int EstudianteId { get; set; }
        public EstudianteDTO Estudiante { get; set; }
        public int PreguntaExamenId { get; set; }
        public PreguntaExamenDTO PreguntaExamen { get; set; }
    }
}
