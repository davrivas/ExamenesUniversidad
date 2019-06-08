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
    public partial class AgregarCurso : Form
    {
        private readonly AgregarCursoControlador _controlador;

        public AgregarCurso()
        {
            InitializeComponent();
            _controlador = new AgregarCursoControlador();
        }

        private void ButtonAgregar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxNombre.Text))
            {
                string codigo;

                do
                {
                    codigo = StringUtilidades.GenerarCodigo();
                } while (_controlador.ExisteCurso(codigo));

                _controlador.CursoNuevo.Codigo = codigo;
                _controlador.CursoNuevo.Nombre = textBoxNombre.Text;

                _controlador.AgregarCursoNuevo();
                MessageBox.Show($"Se registró el curso {textBoxNombre.Text} con el código {codigo} satisfactoriamente");
                Program.InicioProfesor.ActualizarCursos();
                this.Close();
            }
            else
            {
                MessageBox.Show("Debe digitar el nombre del curso", "Error");
            }
        }
    }
}
