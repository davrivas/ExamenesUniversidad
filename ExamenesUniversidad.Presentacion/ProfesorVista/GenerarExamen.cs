using ExamenesUniversidad.Logica.Controladores.ProfesorControladores;
using ExamenesUniversidad.Logica.Utilidades;
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
            dateTimePickerInicio.MinDate = DateTime.Today;
            dateTimePickerFin.MinDate = DateTime.Today;
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
                maskedTextBoxCantidad.Text = "";
                dateTimePickerInicio.Enabled = false;
                dateTimePickerFin.Enabled = false;
                labelCantidadPreguntas.Text = "";
            }
        }

        private void ButtonGenerar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(maskedTextBoxCantidad.Text))
            {
                if (Convert.ToInt32(maskedTextBoxCantidad.Text) >= 1 && Convert.ToInt32(maskedTextBoxCantidad.Text) <= _controlador.CursoAsociado.Preguntas.Count)
                {
                    if (dateTimePickerInicio.Value != dateTimePickerFin.Value)
                    {
                        if (dateTimePickerInicio.Value < dateTimePickerFin.Value)
                        {
                            _controlador.ExamenNuevo.Abierto = true; // no sé
                            _controlador.ExamenNuevo.FechaInicio = dateTimePickerInicio.Value;
                            _controlador.ExamenNuevo.FechaFin = dateTimePickerFin.Value;
                            _controlador.ExamenNuevo.CursoId = _controlador.CursoAsociado.Id;
                            _controlador.ExamenNuevo.ProfesorId = Sesion.ProfesorId;
                            _controlador.GenerarExamen(Convert.ToInt32(maskedTextBoxCantidad.Text));
                            MessageBox.Show("Examen generado con éxito");
                            //Close();
                        }
                        else
                        {
                            MessageBox.Show("La fecha final debe ser después del inicio", "Error");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Las fechas no deben de ser iguales", "Error");
                    }
                }
                else
                {
                    MessageBox.Show($"Debe digitar un número entre 1 y {_controlador.CursoAsociado.Preguntas.Count.ToString()}", "Error");
                }
            }
            else
            {
                MessageBox.Show("Debe digitar un número de preguntas", "Error");
            }
            
        }
    }
}
