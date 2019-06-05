using System.Collections.Generic;

namespace ExamenesUniversidad.Datos.Entidades
{
    public class Estudiante : Usuario
    {
        public int NumeroCarnet { get; set; }
        public ICollection<EstudianteRespuesta> EstudianteRespuestas { get; set; }
    }
}
