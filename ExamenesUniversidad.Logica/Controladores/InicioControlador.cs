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

        public string Usuario { get; set; }
        public string Clave { get; set; }

        public InicioControlador()
        {
            eDAO = new EstudianteDAO();
            pDAO = new ProfesorDAO();
        }

        public bool IniciarEstudiante()
        {
            _claveEncriptada = Clave.GenerarMD5();
            bool existeEstudiante = eDAO.ExisteEstudiante(Usuario, _claveEncriptada);
            return existeEstudiante;
        }

        public bool IniciarProfesor()
        {
            _claveEncriptada = Clave.GenerarMD5();
            bool existeProfesor = pDAO.ExisteProfesor(Usuario, _claveEncriptada);
            return existeProfesor;
        }
    }
}
