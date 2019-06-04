using ExamenesUniversidad.Datos.DTOs.DTOBases;
using System;

namespace ExamenesUniversidad.Datos.DTOs
{
    public class ExamenDTO : DTOBase
    {
        public string Codigo { get; set; }
        public short Abierto { get; set; }
        public int? NumeroPreguntas { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }

        public int CursoId { get; set; }
        public CursoDTO Curso { get; set; }
        public int ProfesorId { get; set; }
        public ProfesorDTO Profesor { get; set; }
    }
}
