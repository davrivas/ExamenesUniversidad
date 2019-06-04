using ExamenesUniversidad.Logica.DAOs;
using ExamenesUniversidad.Logica.DAOs.InterfacesDAO;

namespace ExamenesUniversidad.Logica.Controladores
{
    public class InicioControlador
    {
        private readonly IEstudianteDAO eDAO;
        private readonly IProfesorDAO pDAO;

        public string EstudianteUsuario { get; set; }
        public string EstudianteClave { get; set; }
        public string ProfesorUsuario { get; set; }
        public string ProfesorClave { get; set; }

        public InicioControlador()
        {
            eDAO = new EstudianteDAO();
            pDAO = new ProfesorDAO();
        }

        public bool IniciarEstudiante()
        {
            bool existeEstudiante = eDAO.ExisteEstudiante(EstudianteUsuario, EstudianteClave);
            return existeEstudiante;
        }

        public bool IniciarProfesor()
        {
            bool existeProfesor = pDAO.ExisteProfesor(ProfesorUsuario, ProfesorClave);
            return existeProfesor;
        }
    }
}
