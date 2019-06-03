namespace ExamenesUniversidad.Datos.DTOs
{
    public class PreguntaDTO : DTOBase
    {
        public int NumeroPregunta { get; set; }
        public string Consecutivo { get; set; }
        public string Enunciado { get; set; }

        public int CursoId { get; set; }
        public CursoDTO Curso { get; set; }
    }
}
