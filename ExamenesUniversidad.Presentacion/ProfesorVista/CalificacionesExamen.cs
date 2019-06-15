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

namespace ExamenesUniversidad.Presentacion.ProfesorVista
{
    public partial class CalificacionesExamen : Form
    {
        public CalificacionesExamen()
        {
            InitializeComponent();
        }

        private void ButtonBuscar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxCodigoExamen.Text))
            {
                dataGridViewCalificaciones.DataSource = ProfesorDataSet.ListarResultadosPorExamen(textBoxCodigoExamen.Text);
            }
            else
            {
                MessageBox.Show("Debe digitar un código del examen", "Error");
            }
        }
    }
}
