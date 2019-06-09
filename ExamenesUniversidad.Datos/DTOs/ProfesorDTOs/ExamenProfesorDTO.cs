using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenesUniversidad.Datos.DTOs.ProfesorDTOs
{
    public class ExamenProfesorDTO
    {
        public string Codigo { get; set; }
        public string Abierto { get; set; }
        public string FechaInicio { get; set; }
        public string FechaFin { get; set; }
        public string NombreCurso { get; set; }
        public string NombreProfesor { get; set; }
        public int NumeroPreguntas { get; set; }
    }
}
