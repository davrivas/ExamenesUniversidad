using ExamenesUniversidad.Datos.DTOs.DTOBases;

namespace ExamenesUniversidad.Datos.DTOs
{
    public class PreguntaDTO : DTOBase
    {
        public string Consecutivo { get; set; }
        public string Enunciado { get; set; }
        public string Respuesta1 { get; set; }
        public string Respuesta2 { get; set; }
        public string Respuesta3 { get; set; }
        public string Respuesta4 { get; set; }
        public string Respuesta5 { get; set; }
        public int RespuestaCorrecta { get; set; }

        public int CursoId { get; set; }
        public CursoDTO Curso { get; set; }
    }
}
