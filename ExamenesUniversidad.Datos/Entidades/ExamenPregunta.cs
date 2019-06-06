using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExamenesUniversidad.Datos.Entidades
{
    [Table("ExamenPreguntas")]
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
