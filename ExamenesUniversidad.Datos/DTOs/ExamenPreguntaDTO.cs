using ExamenesUniversidad.Datos.DTOs.DTOBases;

namespace ExamenesUniversidad.Datos.DTOs
{
    public class ExamenPreguntaDTO : DTOBase
    {
        public int NumeroPregunta { get; set; }

        public int PreguntaId { get; set; }
        public PreguntaDTO Pregunta { get; set; }
        public int ExamenId { get; set; }
        public ExamenDTO Examen { get; set; }
    }
}
