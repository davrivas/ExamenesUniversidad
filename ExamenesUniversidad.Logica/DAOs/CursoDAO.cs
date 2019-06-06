using ExamenesUniversidad.Datos.Entidades;
using System;
using System.Linq;

namespace ExamenesUniversidad.Logica.DAOs
{
    public interface ICursoDAO : IDAO<Curso>
    {
        bool ExisteCursoCodigo(string codigo);
    }

    public class CursoDAO : DAO<Curso>, ICursoDAO
    {
        public bool ExisteCursoCodigo(string codigo)
        {
            var curso = Listar().Where(x => x.Codigo == codigo).AsQueryable().FirstOrDefault();
            bool validacion = curso != null;
            return validacion;
        }
    }
}
