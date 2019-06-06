using ExamenesUniversidad.Logica.DAOs;

namespace ExamenesUniversidad.Logica.Controladores
{
    public class InicioControlador
    {
        private readonly IEstudianteDAO estudianteDAO;
        private readonly IProfesorDAO profesorDAO;

        public string Usuario { get; set; }
        public string Clave { get; set; }

        public InicioControlador()
        {
            estudianteDAO = new EstudianteDAO();
            profesorDAO = new ProfesorDAO();
        }

        public bool IniciarEstudiante()
        {
            bool existeEstudiante = estudianteDAO.ExisteEstudiante(Usuario, Clave);
            return existeEstudiante;
        }

        public bool IniciarProfesor()
        {
            bool existeProfesor = profesorDAO.ExisteProfesor(Usuario, Clave);
            return existeProfesor;
        }
    }
}
