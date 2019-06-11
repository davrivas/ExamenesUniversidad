using ExamenesUniversidad.Logica.Controladores.ProfesorControladores;
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
    public partial class AgregarExamen : Form
    {
        private readonly AgregarExamenControlador _controlador;
        private int _cantidadPreguntas;

        public AgregarExamen()
        {
            InitializeComponent();
            _controlador = new AgregarExamenControlador();
        }

        private void ButtonBuscar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxCodigoCurso.Text))
            {
                _controlador.EncontrarCurso(textBoxCodigoCurso.Text);
                _cantidadPreguntas = _controlador.CursoAsociado.Preguntas.Count;
                _controlador.PreguntasCurso = ProfesorDataSet.ListarPreguntasCurso(textBoxCodigoCurso.Text);
                dataGridViewCursoPreguntas.DataSource = _controlador.PreguntasCurso;
            }
        }
    }
}
