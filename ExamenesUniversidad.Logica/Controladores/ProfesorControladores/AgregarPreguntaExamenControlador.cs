using ExamenesUniversidad.Datos.Entidades;
using ExamenesUniversidad.Logica.DAOs;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamenesUniversidad.Datos.DTOs.ProfesorDTOs;
using ExamenesUniversidad.Logica.DataSets;

namespace ExamenesUniversidad.Logica.Controladores.ProfesorControladores
{
    public class AgregarPreguntaExamenControlador
    {
        private readonly IExamenPreguntaDAO _examenPreguntaDAO;
        private readonly IExamenDAO _examenDAO;
        private readonly IPreguntaDAO _preguntaDAO;
        private readonly IProfesorDataSet _profesorDataSet;

        public ExamenPregunta NuevaPreguntaExamen { get; set; }

        public AgregarPreguntaExamenControlador()
        {
            _examenPreguntaDAO = new ExamenPreguntaDAO();
            _examenDAO = new ExamenDAO();
            _preguntaDAO = new PreguntaDAO();
            _profesorDataSet = new ProfesorDataSet();
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

        public IList<PreguntaCursoDTO> ListarPreguntasCursoPorExamen(string codigoExamen)
        {
            return _profesorDataSet.ListarPreguntasCursoPorExamen(codigoExamen);
        }
    }
}
