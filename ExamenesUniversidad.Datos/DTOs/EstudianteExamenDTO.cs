using ExamenesUniversidad.Datos.DTOs.DTOBases;

namespace ExamenesUniversidad.Datos.DTOs
{
    public class EstudianteExamenDTO : DTOBase
    {
        public int EstudianteId { get; set; }
        public EstudianteDTO Estudiante { get; set; }
        public int ExamenId { get; set; }
        public ExamenDTO Examen { get; set; }
        public int? Resultado { get; set; }
    }
}
