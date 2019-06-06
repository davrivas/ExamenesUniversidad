using ExamenesUniversidad.Datos.Entidades;
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

namespace ExamenesUniversidad.Presentacion.Profesor
{
    public partial class InicioProfesor : Form
    {
        private readonly List<Curso> _cursos;

        public InicioProfesor()
        {
            InitializeComponent();
            _cursos = CustomDataSet.GetCursos();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            dataGridView1.DataSource = _cursos;
            dataGridView1.AllowUserToOrderColumns = true;
        }
    }
}
