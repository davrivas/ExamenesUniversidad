using ExamenesUniversidad.Logica.Controladores;
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
            if (!string.IsNullOrWhiteSpace(textBoxUsuario.Text) 
                && !string.IsNullOrWhiteSpace(textBoxClave.Text) 
                && comboBoxRol.Text != "Seleccione rol")
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
                    default:
                        MessageBox.Show("Opción inválida");
                        break;
                }
            }
            else
            {
                MessageBox.Show("Digite todos los campos", "Error");
            }
        }

        private void ButtonRegistrar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxIdentificacion.Text) 
                && !string.IsNullOrWhiteSpace(textBoxNombres.Text)
                && !string.IsNullOrWhiteSpace(textBoxApellidos.Text)
                && !string.IsNullOrWhiteSpace(textBoxUsuarioReg.Text)
                && !string.IsNullOrWhiteSpace(textBoxClaveReg.Text)
                && !string.IsNullOrWhiteSpace(textBoxConfirmar.Text)
                && comboBoxRegistro.Text != "Seleccione rol")
            {
                int identificacion;

                if (int.TryParse(textBoxIdentificacion.Text, out identificacion))
                {
                    _controlador.Usuario = textBoxUsuarioReg.Text;

                    switch (comboBoxRegistro.Text)
                    {
                        case "Profesor":
                            if (!_controlador.ExisteProfesor())
                            {
                                _controlador.ProfesorNuevo = new Profesor();
                            }
                            else
                            {
                                MessageBox.Show("Ya existe un profesor con ese nombre de usuario", "Error");
                            }
                            break;
                        case "Estudiante":
                            if (!_controlador.ExisteEstudiante())
                            {
                                _controlador.EstudianteNuevo = new Estudiante();
                            }
                            else
                            {
                                MessageBox.Show("Ya existe un estudiante con ese nombre de usuario", "Error");
                            }
                            break;
                        default:
                            MessageBox.Show("Opción inválida", "Error");
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Identificación inválida", "Error");
                }
            }
        }
    }
}
