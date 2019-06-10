using ExamenesUniversidad.Datos.DTOs.ProfesorDTOs;
using ExamenesUniversidad.Datos.Entidades;
using ExamenesUniversidad.Logica.DAOs;
using System.Collections.Generic;

namespace ExamenesUniversidad.Logica.Controladores.ProfesorControladores.ExamenesProfesorControladores
{
    public class AgregarExamenControlador
    {
        private readonly IExamenDAO _examenDAO;
        private readonly ICursoDAO _cursoDAO;

        public Examen ExamenNuevo { get; set; }
        public IList<PreguntaCursoDTO> PreguntasCurso { get; set; }
        public Curso CursoAsociado { get; set; }

        public AgregarExamenControlador()
        {
            _examenDAO = new ExamenDAO();
            _cursoDAO = new CursoDAO();
            ExamenNuevo = new Examen();
            PreguntasCurso = new List<PreguntaCursoDTO>();
            CursoAsociado = new Curso();
        }

        public void EncontrarCurso(string codigo)
        {
            CursoAsociado = _cursoDAO.BurcarPorCodigo(codigo);
        }

        public bool ExisteExamen(string codigo)
        {
            return _examenDAO.ExisteExamen(codigo);
        }

        public void AgregarExamen()
        {
            _examenDAO.Ingresar(ExamenNuevo);
            ExamenNuevo = new Examen();
        }
    }
}
