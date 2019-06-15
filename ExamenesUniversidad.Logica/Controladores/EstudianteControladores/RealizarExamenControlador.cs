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
        private readonly IList<ExamenPregunta> _examenPreguntas;

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

        public void RealizarExamen(IList<int> respuestas) // debo mencionar que el examen debe estar hecho o no
        {
            for (int i = 0; i < _examenPreguntas.Count; i++)
            {
                var pregunta = _examenPreguntas[i].Pregunta;
                int respuesta = respuestas[i];
                int examenPreguntaId = _examenPreguntas[i].Id;

                var respuestaEstudiante = new EstudianteRespuesta
                {
                    Respuesta = respuesta,
                    Correcta = respuesta == pregunta.RespuestaCorrecta ? true : false,
                    EstudianteId = Sesion.EstudianteId,
                    ExamenPreguntaId = examenPreguntaId
                };

                _estudianteRespuestaDAO.Ingresar(respuestaEstudiante);
            }
        }
    }
}
