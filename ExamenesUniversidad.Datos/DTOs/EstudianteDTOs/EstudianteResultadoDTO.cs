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
        public string Resultado { get; set; }
    }
}
