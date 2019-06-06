using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExamenesUniversidad.Datos.Entidades
{
    [Table("Profesores")]
    public class Profesor : Usuario
    {
        public int Cedula { get; set; }
        public ICollection<Examen> Examenes { get; set; }
    }
}
