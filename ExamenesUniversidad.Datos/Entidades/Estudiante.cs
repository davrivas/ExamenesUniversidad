using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExamenesUniversidad.Datos.Entidades
{
    [Table("Estudiantes")]
    public class Estudiante : Usuario
    {
        public int NumeroCarnet { get; set; }
        public ICollection<EstudianteRespuesta> EstudianteRespuestas { get; set; }
    }
}
