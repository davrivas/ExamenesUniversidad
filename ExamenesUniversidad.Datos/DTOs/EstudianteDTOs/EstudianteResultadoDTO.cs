using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenesUniversidad.Datos.DTOs.EstudianteDTOs
{
    public class EstudianteResultadoDTO
    {
        public string CodigoExamen { get; set; }
        public string NombreCurso { get; set; }
        public string NombreProfesor { get; set; }
        public int CantidadBien { get; set; }
        public int CantidadMal { get; set; }
        public int TotalPreguntas { get; set; }
    }
}
