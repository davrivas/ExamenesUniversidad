using ExamenesUniversidad.Datos.Entidades;
using ExamenesUniversidad.Logica.DAOs;
using ExamenesUniversidad.Logica.Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenesUniversidad.Logica.Controladores.ProfesorControladores
{
    public class GenerarExamenControlador
    {
        private readonly IExamenDAO _examenDAO;
        private readonly ICursoDAO _cursoDAO;
        private readonly IPreguntaDAO _preguntaDAO;
        private readonly IExamenPreguntaDAO _examenPreguntaDAO;

        public Examen ExamenNuevo { get; set; }
        public Curso CursoAsociado { get; set; }

        public GenerarExamenControlador()
        {
            _examenDAO = new ExamenDAO();
            _cursoDAO = new CursoDAO();
            _preguntaDAO = new PreguntaDAO();
            _examenPreguntaDAO = new ExamenPreguntaDAO();
            ExamenNuevo = new Examen();
            CursoAsociado = new Curso();
        }

        public void EncontrarCurso(string codigo)
        {
            CursoAsociado = _cursoDAO.BurcarPorCodigo(codigo);
        }

        public void GenerarExamen(int cantidadPreguntas)
        {
            string codigoExamen;

            do
            {
                codigoExamen = StringUtilidades.GenerarCodigo();
            } while (_examenDAO.ExisteExamen(codigoExamen));

            ExamenNuevo.Codigo = codigoExamen;
            _examenDAO.Ingresar(ExamenNuevo);

            var preguntas = _preguntaDAO.Listar()
                .Where(x => x.CursoId == CursoAsociado.Id)
                .OrderBy(x => Guid.NewGuid())
                .Take(cantidadPreguntas)
                .ToList();

            var examenId = _examenDAO.ObtenerIdPorCodigo(codigoExamen);

            for (int i = 0; i < preguntas.Count; i++)
            {
                var examenPregunta = new ExamenPregunta
                {
                    NumeroPregunta = (i + 1),
                    ExamenId = examenId,
                    PreguntaId = preguntas[i].Id
                };
                _examenPreguntaDAO.Ingresar(examenPregunta);
            }

            ExamenNuevo = new Examen();
        }
    }
}
