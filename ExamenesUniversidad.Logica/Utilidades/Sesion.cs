using ExamenesUniversidad.Datos.DbContexts;
using ExamenesUniversidad.Datos.Entidades;

namespace ExamenesUniversidad.Logica.Utilidades
{
    public static class Sesion
    {
        public static Estudiante Estudiante { get; set; }
        public static Profesor Profesor { get; set; }
    }
}
