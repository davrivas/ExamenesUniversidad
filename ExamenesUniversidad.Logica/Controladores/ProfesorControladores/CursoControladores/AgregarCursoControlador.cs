using ExamenesUniversidad.Datos.Entidades;
using ExamenesUniversidad.Logica.DAOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenesUniversidad.Logica.Controladores.ProfesorControladores.CursoControladores
{
    public class AgregarCursoControlador
    {
        private readonly ICursoDAO _cursoDAO;

        public Curso CursoNuevo { get; set; }

        public AgregarCursoControlador()
        {
            _cursoDAO = new CursoDAO();
            CursoNuevo = new Curso();
        }

        public void AgregarCursoNuevo()
        {
            _cursoDAO.Ingresar(CursoNuevo);
        }

        public bool ExisteCurso(string codigo)
        {
            return _cursoDAO.ExisteCurso(codigo);
        }
    }
}
