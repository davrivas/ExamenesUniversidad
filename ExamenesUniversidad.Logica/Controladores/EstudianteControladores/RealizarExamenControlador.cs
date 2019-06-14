using ExamenesUniversidad.Datos.Entidades;
using ExamenesUniversidad.Logica.DAOs;
using ExamenesUniversidad.Logica.Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenesUniversidad.Logica.Controladores.EstudianteControladores
{
    public class RealizarExamenControlador
    {
        private readonly IEstudianteRespuestaDAO _estudianteRespuestaDAO;
        private readonly IExamenDAO _examenDAO;
        private readonly IExamenPreguntaDAO _examenPreguntaDAO;

        public Examen ExamenSeleccionado { get; private set; }
        public string TextoPregunta { get; private set; }
        public int CantidadPreguntas { get; private set; }

        public RealizarExamenControlador(string codigo)
        {
            _estudianteRespuestaDAO = new EstudianteRespuestaDAO();
            _examenDAO = new ExamenDAO();
            _examenPreguntaDAO = new ExamenPreguntaDAO();
            ExamenSeleccionado = _examenDAO.ObtenerPorCodigo(codigo);
            CantidadPreguntas = ExamenSeleccionado.ExamenPreguntas.Count;
            TextoPregunta = ObtenerTextoPregunta();
        }

        private string ObtenerTextoPregunta()
        {
            string textoPregunta = "";
            var preguntas = ExamenSeleccionado.ExamenPreguntas.OrderBy(x => x.NumeroPregunta).ToList();

            foreach (var pregunta in preguntas)
            {
                textoPregunta += $"Pregunta {pregunta.NumeroPregunta.ToString()}\n";
                textoPregunta += $"{pregunta.Pregunta.Enunciado}\n";
                textoPregunta += $"1. {pregunta.Pregunta.Respuesta1}\n";
                textoPregunta += $"2. {pregunta.Pregunta.Respuesta2}\n";
                textoPregunta += $"3. {pregunta.Pregunta.Respuesta3}\n";
                textoPregunta += $"4. {pregunta.Pregunta.Respuesta4}\n";
                textoPregunta += $"5. {pregunta.Pregunta.Respuesta5}\n\n";
            }

            return textoPregunta;
        }

        public void RealizarExamen(IList<int> respuestas)
        {
            var examenPreguntas = ExamenSeleccionado.ExamenPreguntas.OrderBy(x => x.NumeroPregunta).ToList();

            //prubeda
            var respuestasTest = new List<EstudianteRespuesta>();

            for (int i = 0; i < examenPreguntas.Count; i++)
            {
                int preguntaId = examenPreguntas[i].PreguntaId;
                int respuesta = respuestas[i];
                int examenPreguntaId = examenPreguntas[i].Id;

                var respuestaEstudiante = new EstudianteRespuesta
                {
                    Respuesta = respuesta,
                    EstudianteId = Sesion.EstudianteId,
                    ExamenPreguntaId = examenPreguntaId
                };
                respuestasTest.Add(respuestaEstudiante);
            }

            Console.WriteLine(respuestasTest);
        }
    }
}
