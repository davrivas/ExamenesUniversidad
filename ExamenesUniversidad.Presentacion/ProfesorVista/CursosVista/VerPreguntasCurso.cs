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

namespace ExamenesUniversidad.Presentacion.ProfesorVista.CursosVista
{
    public partial class VerPreguntasCurso : Form
    {
        public VerPreguntasCurso()
        {
            InitializeComponent();
        }

        private void ButtonBuscar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxCodigo.Text))
            {
                dataGridViewPreguntas.DataSource = ProfesorDataSet.ListarPreguntasCurso(textBoxCodigo.Text);
            }
        }

        private void ButtonAgregarPregunta_Click(object sender, EventArgs e)
        {
            new AgregarPreguntaCurso().Show();
        }
    }
}
