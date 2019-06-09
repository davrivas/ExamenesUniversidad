using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExamenesUniversidad.Datos.Entidades
{
    [Table("Examenes")]
    public class Examen : EntidadBase
    {
        public string Codigo { get; set; }
        public bool Abierto { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }

        public int CursoId { get; set; }
        public Curso Curso { get; set; }
        public int ProfesorId { get; set; }
        public Profesor Profesor { get; set; }

        public ICollection<ExamenPregunta> ExamenPreguntas { get; set; }
    }
}
