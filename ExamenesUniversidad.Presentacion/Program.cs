using ExamenesUniversidad.Presentacion.ProfesorVista;
using System;
using System.Windows.Forms;

namespace ExamenesUniversidad.Presentacion
{
    static class Program
    {
        public static Inicio InicioForm { get; private set; }
        public static InicioProfesor InicioProfesor { get; set; }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            InicioForm = new Inicio();
            Application.Run(InicioForm);
        }
    }
}
