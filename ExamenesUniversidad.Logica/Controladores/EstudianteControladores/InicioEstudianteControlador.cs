using ExamenesUniversidad.Datos.Entidades;
using ExamenesUniversidad.Logica.DAOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenesUniversidad.Logica.Controladores.EstudianteControladores
{
    public class InicioEstudianteControlador
    {
        private readonly IExamenDAO _examenDAO;

        public Examen ExamenBuscado { get; protected set; }

        public InicioEstudianteControlador()
        {
            _examenDAO = new ExamenDAO();
        }

        public void BuscarExamen(string codigo)
        {
            ExamenBuscado = _examenDAO.ObtenerPorCodigo(codigo);
        }
    }
}
