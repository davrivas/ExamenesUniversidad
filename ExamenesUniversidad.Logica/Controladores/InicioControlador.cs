using ExamenesUniversidad.Logica.DAOs;
using ExamenesUniversidad.Logica.DAOs.InterfacesDAO;
using ExamenesUniversidad.Logica.Extensiones;

namespace ExamenesUniversidad.Logica.Controladores
{
    public class InicioControlador
    {
        private readonly IEstudianteDAO eDAO;
        private readonly IProfesorDAO pDAO;
        private string _claveEncriptada;

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
            _claveEncriptada = ProfesorClave.GenerarMD5();
            bool existeEstudiante = eDAO.ExisteEstudiante(EstudianteUsuario, _claveEncriptada);
            return existeEstudiante;
        }

        public bool IniciarProfesor()
        {
            _claveEncriptada = ProfesorClave.GenerarMD5();
            bool existeProfesor = pDAO.ExisteProfesor(ProfesorUsuario, _claveEncriptada);
            return existeProfesor;
        }
    }
}
