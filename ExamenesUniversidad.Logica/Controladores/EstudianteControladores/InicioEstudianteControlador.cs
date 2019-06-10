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

        public InicioEstudianteControlador()
        {
            _examenDAO = new ExamenDAO();
        }

        public bool ExisteExamen(string codigo)
        {
            return _examenDAO.ExisteExamen(codigo);
        }
    }
}
