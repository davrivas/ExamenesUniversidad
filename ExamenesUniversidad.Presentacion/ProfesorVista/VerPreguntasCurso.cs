using System;
using System.Windows.Forms;
using ExamenesUniversidad.Logica.Controladores.ProfesorControladores;

namespace ExamenesUniversidad.Presentacion.ProfesorVista
{
    public partial class VerPreguntasCurso : Form
    {
        private readonly VerPreguntasCursoControlador _controlador;

        public VerPreguntasCurso()
        {
            InitializeComponent();
            _controlador = new VerPreguntasCursoControlador();
        }

        private void ButtonBuscar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxCodigo.Text))
            {
                dataGridViewPreguntas.DataSource = _controlador.ListarPreguntasCurso(textBoxCodigo.Text);
            }
            else
            {
                MessageBox.Show("Digite el codigo del curso", "Error");
            }
        }

        private void ButtonAgregarPregunta_Click(object sender, EventArgs e)
        {
            new AgregarPreguntaCurso().Show();
        }
    }
}
