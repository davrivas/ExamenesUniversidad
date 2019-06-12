using ExamenesUniversidad.Logica.Controladores.ProfesorControladores;
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
    public partial class GenerarExamen : Form
    {
        private readonly GenerarExamenControlador _controlador;

        public GenerarExamen()
        {
            InitializeComponent();
            _controlador = new GenerarExamenControlador();
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
                    if (!buttonGenerar.Enabled)
                    {
                        buttonGenerar.Enabled = true;
                        maskedTextBoxCantidad.Enabled = true;
                        dateTimePickerInicio.Enabled = true;
                        dateTimePickerFin.Enabled = true;
                    }
                    labelCantidadPreguntas.Text = $"Cantidad máxima preguntas ({_controlador.CursoAsociado.Preguntas.Count.ToString()})";
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
            if (buttonGenerar.Enabled)
            {
                buttonGenerar.Enabled = false;
                maskedTextBoxCantidad.Enabled = true;
                dateTimePickerInicio.Enabled = false;
                dateTimePickerFin.Enabled = false;
                labelCantidadPreguntas.Text = "";
            }
        }

        private void ButtonGenerar_Click(object sender, EventArgs e)
        {
            //revisar
        }
    }
}
