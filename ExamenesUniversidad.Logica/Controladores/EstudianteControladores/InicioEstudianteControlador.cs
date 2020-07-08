using ExamenesUniversidad.Datos.Entidades;
using ExamenesUniversidad.Logica.DAOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamenesUniversidad.Datos.DTOs.EstudianteDTOs;
using ExamenesUniversidad.Logica.DataSets;

namespace ExamenesUniversidad.Logica.Controladores.EstudianteControladores
{
    public class InicioEstudianteControlador
    {
        private readonly IEstudianteDataSet _estudianteDataSet;
        private readonly IExamenDAO _examenDAO;

        public Examen ExamenBuscado { get; protected set; }

        public InicioEstudianteControlador()
        {
            _estudianteDataSet = new EstudianteDataSet();
            _examenDAO = new ExamenDAO();
        }

        public void BuscarExamen(string codigo)
        {
            ExamenBuscado = _examenDAO.ObtenerPorCodigo(codigo);
        }

        public IList<ExamenEstudianteDTO> GetExamenes()
        {
            return _estudianteDataSet.GetExamenes();
        }

        public IList<EstudianteResultadoDTO> ListarResultados()
        {
            return _estudianteDataSet.ListarResultados();
        }
    }
}
