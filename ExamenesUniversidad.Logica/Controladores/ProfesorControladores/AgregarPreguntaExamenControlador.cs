using ExamenesUniversidad.Datos.Entidades;
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
        private readonly IPreguntaDAO _preguntaDAO;

        public ExamenPregunta NuevaPreguntaExamen { get; set; }

        public AgregarPreguntaExamenControlador()
        {
            _examenPreguntaDAO = new ExamenPreguntaDAO();
            _examenDAO = new ExamenDAO();
            _preguntaDAO = new PreguntaDAO();
        }

        public bool ExisteExamen(string codigo)
        {
            return _examenDAO.ExisteExamen(codigo);
        }

        public void AgregarPregunta(string codigoExamen, string codigoPregunta)
        {
            int examenId = _examenDAO.ObtenerIdPorCodigo(codigoExamen);
            int preguntaId = _preguntaDAO.ObtenerIdPorCodigo(codigoPregunta);
            int cantidadPreguntas = _examenPreguntaDAO
                .Listar()
                .Where(x => x.ExamenId == examenId)
                .Count();

            NuevaPreguntaExamen = new ExamenPregunta
            {
                NumeroPregunta = cantidadPreguntas + 1,
                ExamenId = examenId,
                PreguntaId = preguntaId
            };
            _examenPreguntaDAO.Ingresar(NuevaPreguntaExamen);
            NuevaPreguntaExamen = new ExamenPregunta();
        }
    }
}
