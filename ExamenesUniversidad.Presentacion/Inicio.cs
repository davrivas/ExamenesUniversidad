﻿using ExamenesUniversidad.Logica.Controladores;
using ExamenesUniversidad.Logica.Extensiones;
using ExamenesUniversidad.Presentacion.Estudiante;
using ExamenesUniversidad.Presentacion.Profesor;
using System;
using System.Windows.Forms;

namespace ExamenesUniversidad.Presentacion
{
    public partial class Inicio : Form
    {
        private readonly InicioControlador _controlador;

        public Inicio()
        {
            InitializeComponent();
            _controlador = new InicioControlador();
        }

        private void ButtonIniciar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxUsuario.Text) && !string.IsNullOrWhiteSpace(textBoxClave.Text) && comboBoxRol.Text != "Seleccione rol")
            {
                _controlador.Usuario = textBoxUsuario.Text;
                _controlador.Clave = textBoxClave.Text.GenerarMD5();

                switch (comboBoxRol.Text)
                {
                    case "Profesor":
                        if (_controlador.IniciarProfesor())
                        {
                            MessageBox.Show("Bienvenido profesor");
                            textBoxUsuario.Text = "";
                            textBoxClave.Text = "";
                            new InicioProfesor().Show();
                            Program.InicioForm.Hide();
                        }                            
                        break;
                    case "Estudiante":
                        if (_controlador.IniciarEstudiante())
                        {
                            MessageBox.Show("Bienvenido estudiante");
                            textBoxUsuario.Text = "";
                            textBoxClave.Text = "";
                            new InicioEstudiante().Show();
                            Program.InicioForm.Hide();
                        }
                        break;
                }
            }
            else
            {
                MessageBox.Show("Digite todos los campos", "Error");
            }
        }
    }
}
