using ExamenesUniversidad.Datos.Entidades;
using ExamenesUniversidad.Logica.DAOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenesUniversidad.Logica.Controladores.ProfesorControladores.CursoControladores
{
    public class AgregarPreguntaCursoControlador
    {
        private readonly IPreguntaDAO _preguntaDAO;
        private readonly ICursoDAO _cursoDAO;

        public Curso CursoNuevo { get; set; }

        public AgregarPreguntaCursoControlador()
        {
            _preguntaDAO = new PreguntaDAO();
            _cursoDAO = new CursoDAO();
            CursoNuevo = new Curso();
        }

        public bool ExisteCurso(string codigo)
        {
            return _cursoDAO.ExisteCurso(codigo);
        }

        public void AgregarPregunta()
        {
            _cursoDAO.Ingresar(CursoNuevo);
            CursoNuevo = new Curso();
        }
    }
}
