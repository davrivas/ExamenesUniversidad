using ExamenesUniversidad.Logica.Controladores.ProfesorControladores.CursoControladores;
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
                if (comboBoxRespuestaCorrecta.Text != "Seleccione respuesta correcta")
                {
                    if (_controlador.ExisteCurso(textBoxCodigoCurso.Text))
                    {
                        string consecutivo;

                        do
                        {
                            consecutivo = StringUtilidades.GenerarCodigo();
                        } while (_controlador.ExistePregunta(consecutivo));

                        _controlador.PreguntaNueva.Consecutivo = consecutivo;
                        _controlador.PreguntaNueva.Curso = _controlador.ObtenerCurso(textBoxCodigoCurso.Text);
                        _controlador.PreguntaNueva.CursoId = _controlador.PreguntaNueva.Curso.Id;
                        _controlador.PreguntaNueva.Enunciado = textBoxEnunciado.Text;
                        _controlador.PreguntaNueva.Respuesta1 = textBoxR1.Text;
                        _controlador.PreguntaNueva.Respuesta2 = textBoxR2.Text;
                        _controlador.PreguntaNueva.Respuesta3 = textBoxR3.Text;
                        _controlador.PreguntaNueva.Respuesta4 = textBoxR4.Text;
                        _controlador.PreguntaNueva.Respuesta5 = textBoxR5.Text;
                        _controlador.PreguntaNueva.RespuestaCorrecta = Convert.ToInt32(comboBoxRespuestaCorrecta.Text);

                        _controlador.AgregarPregunta();
                        MessageBox.Show($"Pregunta agregada con éxito");
                        Close();
                    }
                    else
                    {
                        MessageBox.Show($"El curso {textBoxCodigoCurso.Text} no existe", "Error");
                    }
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
