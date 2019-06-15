using ExamenesUniversidad.Datos.Entidades;
using ExamenesUniversidad.Logica.DAOs;
using ExamenesUniversidad.Logica.Utilidades;
using System.Collections.Generic;
using System.Linq;

namespace ExamenesUniversidad.Logica.Controladores.EstudianteControladores
{
    public class RealizarExamenControlador
    {
        private readonly IEstudianteRespuestaDAO _estudianteRespuestaDAO;
        private readonly IExamenDAO _examenDAO;
        private readonly IList<ExamenPregunta> _examenPreguntas;

        public Examen ExamenSeleccionado { get; private set; }
        public string TextoPregunta { get; private set; }
        public int CantidadPreguntas { get; private set; }

        public RealizarExamenControlador(string codigo)
        {
            _estudianteRespuestaDAO = new EstudianteRespuestaDAO();
            _examenDAO = new ExamenDAO();
            ExamenSeleccionado = _examenDAO.ObtenerPorCodigo(codigo);
            CantidadPreguntas = ExamenSeleccionado.ExamenPreguntas.Count;
            _examenPreguntas = ExamenSeleccionado.ExamenPreguntas.OrderBy(x => x.NumeroPregunta).ToList();
            TextoPregunta = ObtenerTextoPregunta();
        }

        private string ObtenerTextoPregunta()
        {
            string textoPregunta = "";

            foreach (var pregunta in _examenPreguntas)
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
            for (int i = 0; i < _examenPreguntas.Count; i++)
            {
                var examenPregunta = _examenPreguntas[i];
                int respuesta = respuestas[i];

                var respuestaEstudiante = _estudianteRespuestaDAO.ObtenerPorExamenPreguntaIdEstudiante(examenPregunta.Id, Sesion.EstudianteId);

                if (respuestaEstudiante != null)
                {
                    var nuevaRespuestaEstudiante = new EstudianteRespuesta
                    {
                        Id = respuestaEstudiante.Id,
                        Respuesta = respuesta,
                        Correcta = respuesta == examenPregunta.Pregunta.RespuestaCorrecta ? true : false,
                        EstudianteId = respuestaEstudiante.EstudianteId,
                        ExamenPreguntaId = respuestaEstudiante.ExamenPreguntaId,
                    };

                    _estudianteRespuestaDAO.Editar(respuestaEstudiante, nuevaRespuestaEstudiante);
                }
                else
                {
                    respuestaEstudiante = new EstudianteRespuesta
                    {
                        Respuesta = respuesta,
                        Correcta = respuesta == examenPregunta.Pregunta.RespuestaCorrecta ? true : false,
                        EstudianteId = Sesion.EstudianteId,
                        ExamenPreguntaId = examenPregunta.Id
                    };

                    _estudianteRespuestaDAO.Ingresar(respuestaEstudiante);
                }
            }
        }
    }
}
