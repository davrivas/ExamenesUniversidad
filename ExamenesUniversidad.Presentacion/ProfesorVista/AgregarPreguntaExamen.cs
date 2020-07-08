using ExamenesUniversidad.Datos.DTOs.ProfesorDTOs;
using ExamenesUniversidad.Logica.Controladores.ProfesorControladores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ExamenesUniversidad.Presentacion.ProfesorVista
{
    public partial class AgregarPreguntaExamen : Form
    {
        private string _codigoExamen;
        private readonly AgregarPreguntaExamenControlador _controlador;
        private IList<PreguntaCursoDTO> _preguntas;

        public AgregarPreguntaExamen(string codigo)
        {
            InitializeComponent();
            _controlador = new AgregarPreguntaExamenControlador();
            _codigoExamen = codigo;
            _preguntas = _controlador.ListarPreguntasCursoPorExamen(_codigoExamen);
            dataGridViewPreguntas.DataSource = _preguntas;
        }

        private void ButtonAgregarPregunta_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxPregunta.Text))
            {
                if (_preguntas.Any(x => x.Consecutivo == textBoxPregunta.Text))
                {
                    _controlador.AgregarPregunta(_codigoExamen, textBoxPregunta.Text);
                    MessageBox.Show("Pregunta agregada al examen");
                    Program.InicioProfesor.ActualizarExamenes();
                }
                else
                {
                    MessageBox.Show($"La pregunta {textBoxPregunta.Text} no existe", "Error");
                }
            }
            else
            {
                MessageBox.Show("Debe digitar el código de la pregunta", "Error");
            }
        }
    }
}
