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

        public void RegistrarProfesor()
        {
            
        }

        public bool ExisteProfesor()
        {
            return _profesorDAO.ExisteProfesor(Usuario);
        }

        public bool ExisteEstudiante()
        {
            return _estudianteDAO.ExisteEstudiante(Usuario);
        }

        public void RegistrarEstudiante()
        {

        }
    }
}
