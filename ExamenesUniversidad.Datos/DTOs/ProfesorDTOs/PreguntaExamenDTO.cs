using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenesUniversidad.Datos.DTOs.ProfesorDTOs
{
    public class PreguntaExamenDTO
    {
        public string NombreCurso { get; set; }
        public int NumeroPregunta { get; set; }
        public string Consecutivo { get; set; }
        public string Enunciado { get; set; }
        public string Respuesta1 { get; set; }
        public string Respuesta2 { get; set; }
        public string Respuesta3 { get; set; }
        public string Respuesta4 { get; set; }
        public string Respuesta5 { get; set; }
        public int RespuestaCorrecta { get; set; }
    }
}
