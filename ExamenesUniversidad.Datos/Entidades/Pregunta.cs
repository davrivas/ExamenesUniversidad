using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExamenesUniversidad.Datos.Entidades
{
    [Table("Preguntas")]
    public class Pregunta : EntidadBase
    {
        public string Consecutivo { get; set; }
        public string Enunciado { get; set; }
        public string Respuesta1 { get; set; }
        public string Respuesta2 { get; set; }
        public string Respuesta3 { get; set; }
        public string Respuesta4 { get; set; }
        public string Respuesta5 { get; set; }
        public int RespuestaCorrecta { get; set; }

        public int CursoId { get; set; }
        public Curso Curso { get; set; }

        public ICollection<ExamenPregunta> ExamenPreguntas { get; set; }
    }
}
