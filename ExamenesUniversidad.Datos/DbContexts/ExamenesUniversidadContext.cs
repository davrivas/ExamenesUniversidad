using ExamenesUniversidad.Datos.Entidades;
using System.Data.Entity;

namespace ExamenesUniversidad.Datos.DbContexts
{
    public class ExamenesUniversidadContext : DbContext
    {
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

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Curso>()
                .HasMany(x => x.Examenes)
                .WithRequired(x => x.Curso)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Curso>()
                .HasMany(x => x.Preguntas)
                .WithRequired(x => x.Curso)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Estudiante>()
                .HasMany(x => x.EstudianteRespuestas)
                .WithRequired(x => x.Estudiante)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Examen>()
                .HasMany(x => x.ExamenPreguntas)
                .WithRequired(x => x.Examen)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Pregunta>()
                .HasMany(x => x.ExamenPreguntas)
                .WithRequired(x => x.Pregunta)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Profesor>()
                .HasMany(x => x.Examenes)
                .WithRequired(x => x.Profesor)
                .WillCascadeOnDelete(false);
        }
    }
}
