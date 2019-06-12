using ExamenesUniversidad.Datos.Entidades;
using ExamenesUniversidad.Logica.DAOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenesUniversidad.Logica.Controladores.ProfesorControladores
{
    public class GenerarExamenControlador
    {
        private readonly IExamenDAO _examenDAO;
        private readonly ICursoDAO _cursoDAO;

        public Examen ExamenNuevo { get; set; }
        public Curso CursoAsociado { get; set; }

        public GenerarExamenControlador()
        {
            _examenDAO = new ExamenDAO();
            _cursoDAO = new CursoDAO();
            ExamenNuevo = new Examen();
            CursoAsociado = new Curso();
        }

        public void EncontrarCurso(string codigo)
        {
            CursoAsociado = _cursoDAO.BurcarPorCodigo(codigo);
        }

        public void GenerarExamen(int cantidadPreguntas)
        {
            // aqui genero las preguntas
            _examenDAO.Ingresar(ExamenNuevo);
            ExamenNuevo = new Examen();
        }
    }
}
