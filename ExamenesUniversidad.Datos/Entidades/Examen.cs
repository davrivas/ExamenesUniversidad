﻿using System;
using System.Collections.Generic;

namespace ExamenesUniversidad.Datos.Entidades
{
    public class Examen : EntidadBase
    {
        public string Codigo { get; set; }
        public short Abierto { get; set; }
        public int? NumeroPreguntas { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }

        public int CursoId { get; set; }
        public Curso Curso { get; set; }
        public int ProfesorId { get; set; }
        public Profesor Profesor { get; set; }

        public ICollection<ExamenPregunta> ExamenPreguntas { get; set; }
    }
}