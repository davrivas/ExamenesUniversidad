using System.Collections.Generic;

namespace ExamenesUniversidad.Datos.Entidades
{
    public class Curso : EntidadBase
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public ICollection<Examen> Examenes { get; set; }
        public ICollection<Pregunta> Preguntas { get; set; }
    }
}
