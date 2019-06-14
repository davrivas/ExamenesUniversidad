using ExamenesUniversidad.Logica.Controladores.EstudianteControladores;
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

namespace ExamenesUniversidad.Presentacion.EstudianteVista
{
    public partial class InicioEstudiante : Form
    {
        private readonly InicioEstudianteControlador _controlador;

        public InicioEstudiante()
        {
            InitializeComponent();
            _controlador = new InicioEstudianteControlador();
            ActualizarExamenes();
        }

        public void ActualizarExamenes()
        {
            dataGridViewExamenes.DataSource = EstudianteDataSet.GetExamenes();
        }

        private void ButtonCerrarSesion_Click(object sender, EventArgs e)
        {
            Program.InicioForm.Show();
            Close();
        }

        private void ButtonRefrescar_Click(object sender, EventArgs e)
        {
            ActualizarExamenes();
        }

        private void ButtonRealizarExamen_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxCodigoExamen.Text))
            {
                _controlador.BuscarExamen(textBoxCodigoExamen.Text);

                if (_controlador.ExamenBuscado != null)
                {
                    if (_controlador.ExamenBuscado.Abierto)
                    {
                        var controlador = new RealizarExamenControlador(textBoxCodigoExamen.Text);
                        var formulario = new RealizarExamen(controlador);
                        formulario.Show();
                    }
                    else
                    {
                        MessageBox.Show($"El examen está {textBoxCodigoExamen.Text} cerrado", "Error");
                    }
                }
                else
                {
                    MessageBox.Show($"El examen {textBoxCodigoExamen.Text} no existe", "Error");
                }
            }
            else
            {
                MessageBox.Show("Digite el código del examen", "Error");
            }
        }
    }
}
