using ExamenesUniversidad.Logica.Controladores.ProfesorControladores.CursoControladores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenesUniversidad.Presentacion.ProfesorVista.CursosVista
{
    public partial class AgregarPreguntaCurso : Form
    {
        private readonly AgregarPreguntaCursoControlador _controlador;

        public AgregarPreguntaCurso()
        {
            InitializeComponent();
            _controlador = new AgregarPreguntaCursoControlador();
        }

        private void ButtonAgregar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxCodigoCurso.Text)
                && !string.IsNullOrWhiteSpace(textBoxEnunciado.Text)
                && !string.IsNullOrWhiteSpace(textBoxR1.Text)
                && !string.IsNullOrWhiteSpace(textBoxR2.Text)
                && !string.IsNullOrWhiteSpace(textBoxR3.Text)
                && !string.IsNullOrWhiteSpace(textBoxR4.Text)
                && !string.IsNullOrWhiteSpace(textBoxR5.Text))
            {
                if (comboBoxRespuestaCorrecta.Text != "")
                {

                }
                else
                {
                    MessageBox.Show("Debe seleccionar una respuesta correcta para la pregunta", "Error");
                }
            }
            else
            {
                MessageBox.Show("Digite todos los campos", "Error");
            }
        }
    }
}
