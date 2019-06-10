using ExamenesUniversidad.Datos.Entidades;
using ExamenesUniversidad.Logica.DAOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenesUniversidad.Logica.Controladores.EstudianteControladores
{
    public class RealizarExamenControlador
    {
        private readonly IExamenDAO _examenDAO;
        private readonly IPreguntaDAO _preguntaDAO;

        public Examen ExamenSeleccionado { get; private set; }
        public string TextoPregunta { get; private set; }

        public RealizarExamenControlador(string codigo)
        {
            _examenDAO = new ExamenDAO();
            _preguntaDAO = new PreguntaDAO();
            ExamenSeleccionado = _examenDAO.ObtenerPorCodigo(codigo);
            TextoPregunta = ObtenerTextoPregunta();
        }

        private string ObtenerTextoPregunta()
        {
            string textoPregunta = "";

            foreach (var pregunta in ExamenSeleccionado.ExamenPreguntas.OrderBy(x => x.NumeroPregunta))
            {
                textoPregunta += $"Pregunta {pregunta.NumeroPregunta.ToString()}\n";

                pregunta.Pregunta = _preguntaDAO.BuscarPorId(pregunta.PreguntaId);
                textoPregunta += $"{pregunta.Pregunta.Enunciado}\n";
                textoPregunta += $"1. {pregunta.Pregunta.Respuesta1}\n";
                textoPregunta += $"2. {pregunta.Pregunta.Respuesta2}\n";
                textoPregunta += $"3. {pregunta.Pregunta.Respuesta3}\n";
                textoPregunta += $"4. {pregunta.Pregunta.Respuesta4}\n";
                textoPregunta += $"5. {pregunta.Pregunta.Respuesta5}\n\n";
            }

            return textoPregunta;
        }
    }
}
