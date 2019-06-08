using ExamenesUniversidad.Logica.Utilidades;
using ExamenesUniversidad.Presentacion.DataSets;
using ExamenesUniversidad.Presentacion.ProfesorVista.CursosVista;
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
    public partial class InicioProfesor : Form
    {
        public InicioProfesor()
        {
            InitializeComponent();
            ActualizarCursos();
        }

        public void ActualizarCursos()
        {
            dataGridViewCursos.DataSource = ProfesorDataSet.ListarCursos();
        }

        private void ButtonAgregarCurso_Click(object sender, EventArgs e)
        {
            new AgregarCurso().Show();
        }

        private void ButtonCerrarSesion_Click(object sender, EventArgs e)
        {
            Program.InicioForm.Show();
            this.Close();
        }
    }
}
