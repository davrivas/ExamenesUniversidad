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
    public partial class VerPreguntasExamen : Form
    {
        public VerPreguntasExamen()
        {
            InitializeComponent();
        }

        private void ButtonBuscar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxCodigo.Text))
            {
                dataGridViewPreguntas.DataSource = ProfesorDataSet.ListarPreguntasExamen(textBoxCodigo.Text);
            }
            else
            {
                MessageBox.Show("Digite el codigo del examen", "Error");
            }
        }
    }
}
