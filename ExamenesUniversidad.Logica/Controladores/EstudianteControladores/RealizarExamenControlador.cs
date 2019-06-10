using ExamenesUniversidad.Datos.Entidades;
using ExamenesUniversidad.Logica.DAOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenesUniversidad.Logica.Controladores.EstudianteControladores
{
    public class RealizarExamenControlador
    {
        private readonly IExamenDAO _examenDAO;

        public Examen ExamenSeleccionado { get; private set; }

        public RealizarExamenControlador(string codigo)
        {
            _examenDAO = new ExamenDAO();
            ExamenSeleccionado = _examenDAO.ObtenerPorCodigo(codigo);
        }
    }
}
