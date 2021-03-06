using ExamenesUniversidad.Logica.Controladores.EstudianteControladores;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ExamenesUniversidad.Presentacion.EstudianteVista
{
    public partial class RealizarExamen : Form
    {
        private readonly RealizarExamenControlador _controlador;
        private readonly IList<ComboBox> _comboBoxes;

        public RealizarExamen(RealizarExamenControlador controlador)
        {
            InitializeComponent();
            _controlador = controlador;
            labelPreguntas.Text = _controlador.TextoPregunta;
            _comboBoxes = new List<ComboBox>();
            GenerarPreguntas();
        }

        private void GenerarPreguntas()
        {
            var labels = new List<Label>();

            for (int i = 0; i < _controlador.CantidadPreguntas; i++)
            {
                var label = new Label
                {
                    AutoSize = true,
                    Name = $"labelRespuesta{i + 1}",
                    Text = $"Pregunta {i + 1}"
                };

                var comboBox = new ComboBox
                {
                    FormattingEnabled = true,
                    Name = $"comboBoxRespuesta{i + 1}",
                    Size = new Size(100, 21),
                    DataSource = new object[] { 1, 2, 3, 4, 5 }
                };

                if (i == 0)
                {
                    label.Location = new Point(15, 14);
                    comboBox.Location = new Point(102, 14);
                }
                else
                {
                    var labelAnterior = labels[i - 1];
                    var sumaAnterior = labelAnterior.Location.Y + 27;
                    label.Location = new Point(13, sumaAnterior);
                    comboBox.Location = new Point(102, sumaAnterior);
                }

                labels.Add(label);
                _comboBoxes.Add(comboBox);
            }

            labels.ToList().ForEach(x => panelRespuestas.Controls.Add(x));
            _comboBoxes.ToList().ForEach(x => panelRespuestas.Controls.Add(x));
        }

        private void ButtonRealizarExamen_Click(object sender, EventArgs e)
        {
            var salir = MessageBox.Show("¿Confirma las respuestas del examen?", "Pregunta", MessageBoxButtons.YesNo);

            if (salir == DialogResult.No)
                return;

            var respuestas = _comboBoxes.Select(x => (int)x.SelectedValue).ToList();
            _controlador.RealizarExamen(respuestas);

            Program.InicioEstudiante.ActualizarExamenes();
            MessageBox.Show("Realizó el examen con éxito");
            
            Close();
        }
    }
}
