using System.Collections.Generic;

namespace ExamenesUniversidad.Datos.Entidades
{
    public class Profesor : Usuario
    {
        public int Cedula { get; set; }
        public ICollection<Examen> Examenes { get; set; }
    }
}
