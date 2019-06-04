using ExamenesUniversidad.Logica.Controladores;
using System.Windows.Forms;

namespace ExamenesUniversidad.Presentacion
{
    public partial class Inicio : Form
    {
        private readonly InicioControlador _controlador;

        public Inicio()
        {
            InitializeComponent();
            _controlador = new InicioControlador();
        }
    }
}
