using System.Collections.Generic;

namespace ExamenesUniversidad.Datos.Entidades
{
    public class ExamenPregunta : EntidadBase
    {
        public int NumeroPregunta { get; set; }

        public int PreguntaId { get; set; }
        public Pregunta Pregunta { get; set; }
        public int ExamenId { get; set; }
        public Examen Examen { get; set; }

        public ICollection<EstudianteRespuesta> EstudianteRespuestas { get; set; }
    }
}
