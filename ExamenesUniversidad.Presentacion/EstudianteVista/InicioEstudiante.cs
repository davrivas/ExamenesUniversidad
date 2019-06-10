using ExamenesUniversidad.Presentacion.DataSets;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenesUniversidad.Presentacion.EstudianteVista
{
    public partial class InicioEstudiante : Form
    {
        public InicioEstudiante()
        {
            InitializeComponent();
            ActualizarExamenes();
        }

        private void ActualizarExamenes()
        {
            dataGridViewExamenes.DataSource = EstudianteDataSet.GetExamenes();
        }

        private void ButtonCerrarSesion_Click(object sender, EventArgs e)
        {
            Program.InicioForm.Show();
            Close();
        }

        private void ButtonRefrescar_Click(object sender, EventArgs e)
        {
            ActualizarExamenes();
        }
    }
}
