using ExamenesUniversidad.Datos.Entidades;
using ExamenesUniversidad.Logica.DAOs.InterfacesDAO;
using System;

namespace ExamenesUniversidad.Logica.DAOs
{
    public class CursoDAO : DAO<Curso>, ICursoDAO
    {
        public bool ExisteCursoCodigo(string codigo)
        {
            throw new NotImplementedException();
        }
    }
}
