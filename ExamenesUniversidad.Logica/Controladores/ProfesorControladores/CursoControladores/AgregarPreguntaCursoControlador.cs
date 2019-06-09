using ExamenesUniversidad.Datos.Entidades;
using ExamenesUniversidad.Logica.DAOs;

namespace ExamenesUniversidad.Logica.Controladores.ProfesorControladores.CursoControladores
{
    public class AgregarPreguntaCursoControlador
    {
        private readonly IPreguntaDAO _preguntaDAO;
        private readonly ICursoDAO _cursoDAO;

        public Pregunta PreguntaNueva { get; set; }

        public AgregarPreguntaCursoControlador()
        {
            _preguntaDAO = new PreguntaDAO();
            _cursoDAO = new CursoDAO();
            PreguntaNueva = new Pregunta();
        }

        public bool ExisteCurso(string codigo)
        {
            return _cursoDAO.ExisteCurso(codigo);
        }

        public int ObtenerCurso(string codigo)
        {
            return _cursoDAO.ObtenerIdPorCodigo(codigo);
        }

        public bool ExistePregunta(string codigo)
        {
            return _preguntaDAO.ExistePregunta(codigo);
        }

        public void AgregarPregunta()
        {
            _preguntaDAO.Ingresar(PreguntaNueva);
            PreguntaNueva = new Pregunta();
        }
    }
}
