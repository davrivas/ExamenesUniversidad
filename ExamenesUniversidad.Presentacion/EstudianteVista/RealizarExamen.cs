using ExamenesUniversidad.Logica.Controladores.EstudianteControladores;
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
    public partial class RealizarExamen : Form
    {
        private readonly RealizarExamenControlador _controlador;

        public RealizarExamen(RealizarExamenControlador controlador)
        {
            InitializeComponent();
            _controlador = controlador;
        }
    }
}
