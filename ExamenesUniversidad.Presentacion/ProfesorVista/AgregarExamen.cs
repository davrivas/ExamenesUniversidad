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
            _cantidadPreguntas = 0;
            labelCantidadPreguntas.Text = "";
            dateTimePickerInicio.MinDate = DateTime.Now;
            dateTimePickerFin.MinDate = DateTime.Now;
        }

        private void ButtonBuscar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxCodigoCurso.Text))
            {
                _controlador.EncontrarCurso(textBoxCodigoCurso.Text);

                if (_controlador.CursoAsociado != null)
                {
                    if (!buttonGenerarEscoger.Enabled && !buttonGenerarAlAzar.Enabled)
                    {
                        buttonGenerarEscoger.Enabled = true;
                        buttonGenerarAlAzar.Enabled = true;
                    }

                    _cantidadPreguntas = _controlador.CursoAsociado.Preguntas.Count;
                    labelCantidadPreguntas.Text = $"Cantidad máxima de preguntas ({_cantidadPreguntas.ToString()})";
                    _controlador.PreguntasCurso = ProfesorDataSet.ListarPreguntasCurso(textBoxCodigoCurso.Text);
                    dataGridViewCursoPreguntas.DataSource = _controlador.PreguntasCurso;
                    ((ListBox)checkedListBoxPreguntas).DataSource = _controlador.PreguntasCurso;
                    ((ListBox)checkedListBoxPreguntas).ValueMember = "Consecutivo";
                    ((ListBox)checkedListBoxPreguntas).DisplayMember = "Enunciado";
                }
                else
                {
                    MessageBox.Show($"El curso {textBoxCodigoCurso.Text} no existe", "Error");
                    ReiniciarCampos();
                }
            }
            else
            {
                MessageBox.Show("Debe digitar el código del curso", "Error");
                ReiniciarCampos();
            }
        }

        private void ReiniciarCampos()
        {
            if (buttonGenerarEscoger.Enabled && buttonGenerarAlAzar.Enabled)
            {
                buttonGenerarEscoger.Enabled = false;
                buttonGenerarAlAzar.Enabled = false;
                labelCantidadPreguntas.Text = "";
                dataGridViewCursoPreguntas.DataSource = new object[0];
                ((ListBox)checkedListBoxPreguntas).DataSource = new object[0];
                ((ListBox)checkedListBoxPreguntas).ValueMember = "";
                ((ListBox)checkedListBoxPreguntas).DisplayMember = "";
            }
        }
    }
}
