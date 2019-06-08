using ExamenesUniversidad.Datos.Entidades;
using ExamenesUniversidad.Logica.DAOs;

namespace ExamenesUniversidad.Logica.Controladores
{
    public class InicioControlador
    {
        private readonly IEstudianteDAO _estudianteDAO;
        private readonly IProfesorDAO _profesorDAO;

        public Estudiante EstudianteNuevo { get; set; }
        public Profesor ProfesorNuevo { get; set; }
        public string Usuario { get; set; }
        public string Clave { get; set; }

        public InicioControlador()
        {
            _estudianteDAO = new EstudianteDAO();
            _profesorDAO = new ProfesorDAO();
            EstudianteNuevo = new Estudiante();
            ProfesorNuevo = new Profesor();
        }

        public bool IniciarEstudiante()
        {
            bool existeEstudiante = _estudianteDAO.ExisteEstudiante(Usuario, Clave);
            return existeEstudiante;
        }

        public bool IniciarProfesor()
        {
            bool existeProfesor = _profesorDAO.ExisteProfesor(Usuario, Clave);
            return existeProfesor;
        }

        public bool ExisteProfesor()
        {
            return _profesorDAO.ExisteProfesor(Usuario);
        }

        public void RegistrarProfesor()
        {
            _profesorDAO.Ingresar(ProfesorNuevo);
            ProfesorNuevo = new Profesor();
        }

        public bool ExisteEstudiante()
        {
            return _estudianteDAO.ExisteEstudiante(Usuario);
        }

        public void RegistrarEstudiante()
        {
            _estudianteDAO.Ingresar(EstudianteNuevo);
            EstudianteNuevo = new Estudiante();
        }
    }
}
