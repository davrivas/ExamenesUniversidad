using ExamenesUniversidad.Presentacion.DataSets;
using System;
using System.Windows.Forms;

namespace ExamenesUniversidad.Presentacion.ProfesorVista
{
    public partial class InicioProfesor : Form
    {
        public InicioProfesor()
        {
            InitializeComponent();
            ActualizarCursos();
            ActualizarExamenes();
        }

        public void ActualizarCursos()
        {
            dataGridViewCursos.DataSource = ProfesorDataSet.ListarCursos();
        }

        public void ActualizarExamenes()
        {
            dataGridViewExamenes.DataSource = ProfesorDataSet.ListarExamenes();
        }

        private void ButtonAgregarCurso_Click(object sender, EventArgs e)
        {
            new AgregarCurso().Show();
        }

        private void ButtonCerrarSesion_Click(object sender, EventArgs e)
        {
            Program.InicioForm.Show();
            Close();
        }

        private void ButtonRefrescarCursos_Click(object sender, EventArgs e)
        {
            ActualizarCursos();
        }

        private void ButtonPreguntas_Click(object sender, EventArgs e)
        {
            new VerPreguntasCurso().Show();
        }

        private void ButtonAgregarExamen_Click(object sender, EventArgs e)
        {
            new CrearExamenVacio().Show();
        }

        private void ButtonRefrescarExamenes_Click(object sender, EventArgs e)
        {
            ActualizarExamenes();
        }

        private void ButtonCalificaciones_Click(object sender, EventArgs e)
        {
            new CalificacionesExamen().Show();
        }

        private void ButtonGenerarExamen_Click(object sender, EventArgs e)
        {
            new GenerarExamen().Show();
        }

        private void ButtonAgregarPregunta_Click(object sender, EventArgs e)
        {
            if (dataGridViewExamenes.SelectedRows.Count > 0)
            {
                var fila = dataGridViewExamenes.SelectedRows[0];
                string codigo = fila.Cells["Codigo"].Value.ToString();
                new AgregarPreguntaExamen(codigo).Show();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila de examen", "Error");
            }
        }
    }
}
