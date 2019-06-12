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
    public partial class CrearExamenVacio : Form
    {
        private readonly CrearExamenVacioControlador _controlador;

        public CrearExamenVacio()
        {
            InitializeComponent();
            _controlador = new CrearExamenVacioControlador();
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
                    if (!buttonGenerarEscoger.Enabled)
                    {
                        buttonGenerarEscoger.Enabled = true;
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
            if (buttonGenerarEscoger.Enabled)
            {
                buttonGenerarEscoger.Enabled = false;
                dateTimePickerInicio.Enabled = false;
                dateTimePickerFin.Enabled = false;
            }
        }
    }
}
