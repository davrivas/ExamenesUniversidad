using ExamenesUniversidad.Datos.Entidades;
using ExamenesUniversidad.Logica.DAOs.InterfacesDAO;
using System;
using System.Data.SqlClient;

namespace ExamenesUniversidad.Logica.DAOs
{
    public class CursoDAO : DAO<Curso>, ICursoDAO
    {
        public CursoDAO() : base("Cursos")
        {
        }

        public bool ExisteCursoCodigo(string codigo)
        {
            throw new NotImplementedException();
        }
    }
}
