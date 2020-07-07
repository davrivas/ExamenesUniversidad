using ExamenesUniversidad.Logica.Controladores.ProfesorControladores;
using ExamenesUniversidad.Logica.Utilidades;
using System;
using System.Windows.Forms;

namespace ExamenesUniversidad.Presentacion.ProfesorVista
{
    public partial class CrearExamenVacio : Form
    {
        private readonly CrearExamenVacioControlador _controlador;

        public CrearExamenVacio()
        {
            InitializeComponent();
            _controlador = new CrearExamenVacioControlador();
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
                    if (!buttonCrear.Enabled)
                    {
                        buttonCrear.Enabled = true;
                        dateTimePickerInicio.Enabled = true;
                        dateTimePickerFin.Enabled = true;
                    }
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
            if (buttonCrear.Enabled)
            {
                buttonCrear.Enabled = false;
                dateTimePickerInicio.Enabled = false;
                dateTimePickerFin.Enabled = false;
            }
        }

        private void ButtonCrear_Click(object sender, EventArgs e)
        {
            if (dateTimePickerInicio.Value != dateTimePickerFin.Value)
            {
                if (dateTimePickerInicio.Value < dateTimePickerFin.Value)
                {
                    _controlador.ExamenNuevo.Abierto = true; // no sé
                    _controlador.ExamenNuevo.FechaInicio = dateTimePickerInicio.Value;
                    _controlador.ExamenNuevo.FechaFin = dateTimePickerFin.Value;
                    _controlador.ExamenNuevo.CursoId = _controlador.CursoAsociado.Id;
                    _controlador.ExamenNuevo.ProfesorId = Sesion.Profesor.Id;
                    _controlador.AgregarExamen();
                    MessageBox.Show("Examen generado con éxito");
                    Program.InicioProfesor.ActualizarExamenes();
                    Close();
                }
                else
                {
                    MessageBox.Show("La fecha final debe ser después del inicio", "Error");
                }
            }
        }
    }
}
