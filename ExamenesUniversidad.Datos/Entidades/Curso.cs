using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExamenesUniversidad.Datos.Entidades
{
    [Table("Cursos")]
    public class Curso : EntidadBase
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public ICollection<Examen> Examenes { get; set; }
        public ICollection<Pregunta> Preguntas { get; set; }
    }
}
