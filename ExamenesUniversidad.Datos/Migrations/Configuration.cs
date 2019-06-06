using ExamenesUniversidad.Datos.DbContexts;
using System.Data.Entity.Migrations;

namespace ExamenesUniversidad.Datos.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<ExamenesUniversidadContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }
    }
}
