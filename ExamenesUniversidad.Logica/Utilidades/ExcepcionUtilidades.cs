using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace ExamenesUniversidad.Logica.Utilidades
{
    public static class ExcepcionUtilidades
    {
        public static void DebugWriteLineMessageBoxShowExcepcion(Exception ex)
        {
            Debug.WriteLine(ex.StackTrace);
            MessageBox.Show("Ocurrió un error: " + ex.Message, "Error");
        }
    }
}
