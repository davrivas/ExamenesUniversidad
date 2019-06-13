using ExamenesUniversidad.Logica.DAOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenesUniversidad.Logica.Controladores.ProfesorControladores
{
    public class AgregarPreguntaExamenControlador
    {
        private readonly IExamenPreguntaDAO _examenPreguntaDAO;
        private readonly IExamenDAO _examenDAO;

        public AgregarPreguntaExamenControlador()
        {
            _examenPreguntaDAO = new ExamenPreguntaDAO();
            _examenDAO = new ExamenDAO();
        }

        public bool ExisteExamen(string codigo)
        {
            return _examenDAO.ExisteExamen(codigo);
        }
    }
}
