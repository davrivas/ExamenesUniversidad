using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenesUniversidad.Datos.DTOs
{
    public class CursoProfesorDTO
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public int CantidadPreguntas { get; set; }
        public int CantidadExamenes { get; set; }
    }
}
