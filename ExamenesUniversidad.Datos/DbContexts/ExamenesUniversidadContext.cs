using ExamenesUniversidad.Datos.Entidades;
using System.Data.Entity;

namespace ExamenesUniversidad.Datos.DbContexts
{
    public class ExamenesUniversidadContext : DbContext
    {
        // esto puede cambiar
        private const string CONNECTION_STRING = @"Data Source=DESKTOP-0S26F42\SQLEXPRESS;Initial Catalog=ExamenesUniversidad;Integrated Security=True";

        public ExamenesUniversidadContext() : base(CONNECTION_STRING)
        {
        }

        public IDbSet<Curso> Cursos { get; set; }
        public IDbSet<Estudiante> Estudiantes { get; set; }
        public IDbSet<EstudianteRespuesta> EstudianteRespuestas { get; set; }
        public IDbSet<Examen> Examenes { get; set; }
        public IDbSet<ExamenPregunta> ExamenPreguntas { get; set; }
        public IDbSet<Pregunta> Preguntas { get; set; }
        public IDbSet<Profesor> Profesores { get; set; }
    }
}
