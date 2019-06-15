using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenesUniversidad.Datos.DTOs.ProfesorDTOs
{
    public class ExamenResultadoDTO
    {
        public string CodigoExamen { get; set; }
        public string NombreCurso { get; set; }
        public string NombreEstudiante { get; set; }
        public int NumeroCarnet { get; set; }
        public string Resultado { get; set; }
    }
}
