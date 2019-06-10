using ExamenesUniversidad.Logica.Controladores;
using ExamenesUniversidad.Logica.Extensiones;
using ExamenesUniversidad.Presentacion.EstudianteVista;
using ExamenesUniversidad.Presentacion.ProfesorVista;
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
                && !string.IsNullOrWhiteSpace(textBoxClave.Text))
            {
                if (comboBoxRol.Text != "Seleccione rol")
                {
                    _controlador.Usuario = textBoxUsuario.Text;
                    _controlador.Clave = textBoxClave.Text.GenerarMD5();

                    switch (comboBoxRol.Text)
                    {
                        case "Profesor":
                            if (_controlador.IniciarProfesor())
                            {
                                BorrarTodosLosCampos();
                                MessageBox.Show("Bienvenido profesor");
                                Program.InicioProfesor = new InicioProfesor();
                                Program.InicioProfesor.Show();
                                Program.InicioForm.Hide();
                            }
                            break;
                        case "Estudiante":
                            if (_controlador.IniciarEstudiante())
                            {
                                BorrarTodosLosCampos();
                                MessageBox.Show("Bienvenido estudiante");
                                Program.InicioEstudiante = new InicioEstudiante();
                                Program.InicioEstudiante.Show();
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
                    MessageBox.Show("Debe seleccionar un rol", "Error");
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
                && !string.IsNullOrWhiteSpace(textBoxConfirmar.Text))
            {
                if (comboBoxRegistro.Text != "Seleccione rol")
                {
                    if (int.TryParse(textBoxIdentificacion.Text, out int identificacion))
                    {
                        if (textBoxClaveReg.Text == textBoxConfirmar.Text)
                        {
                            _controlador.Usuario = textBoxUsuarioReg.Text;

                            switch (comboBoxRegistro.Text)
                            {
                                case "Profesor":
                                    if (!_controlador.ExisteProfesor())
                                    {
                                        _controlador.ProfesorNuevo.Cedula = identificacion;
                                        _controlador.ProfesorNuevo.Nombres = textBoxNombres.Text;
                                        _controlador.ProfesorNuevo.Apellidos = textBoxApellidos.Text;
                                        _controlador.ProfesorNuevo.NombreUsuario = textBoxUsuarioReg.Text;
                                        _controlador.ProfesorNuevo.Clave = textBoxClaveReg.Text.GenerarMD5();

                                        _controlador.RegistrarProfesor();
                                        BorrarCamposRegistrar();
                                        MessageBox.Show("Profesor registrado");
                                    }
                                    else
                                    {
                                        MessageBox.Show("Ya existe un profesor con ese nombre de usuario", "Error");
                                    }
                                    break;
                                case "Estudiante":
                                    if (!_controlador.ExisteEstudiante())
                                    {
                                        _controlador.EstudianteNuevo.NumeroCarnet = identificacion;
                                        _controlador.EstudianteNuevo.Nombres = textBoxNombres.Text;
                                        _controlador.EstudianteNuevo.Apellidos = textBoxApellidos.Text;
                                        _controlador.EstudianteNuevo.NombreUsuario = textBoxUsuarioReg.Text;
                                        _controlador.EstudianteNuevo.Clave = textBoxClaveReg.Text.GenerarMD5();

                                        _controlador.RegistrarEstudiante();
                                        BorrarCamposRegistrar();
                                        MessageBox.Show("Estudiante registrado");
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
                            MessageBox.Show("Las claves deben de coincidir", "Error");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Identificación inválida", "Error");
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un rol", "Error");
                }
            }
            else
            {
                MessageBox.Show("Digite todos los campos", "Error");
            }
        }

        public void BorrarCamposIngresar()
        {
            textBoxUsuario.Text = "";
            textBoxClave.Text = "";
        }

        public void BorrarCamposRegistrar()
        {
            textBoxNombres.Text = "";
            textBoxApellidos.Text = "";
            textBoxUsuarioReg.Text = "";
            textBoxClaveReg.Text = "";
            textBoxConfirmar.Text = "";
        }

        public void BorrarTodosLosCampos()
        {
            BorrarCamposIngresar();
            BorrarCamposRegistrar();
        }

        private void Inicio_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
