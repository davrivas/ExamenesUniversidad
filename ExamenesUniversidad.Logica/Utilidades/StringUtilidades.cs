using System;

namespace ExamenesUniversidad.Logica.Utilidades
{
    public static class StringUtilidades
    {
        private const string CARACTERES = "abcdefghijklmnopqrstuvwxyz1234567890";
        private static readonly int _cantidadCaracteres = CARACTERES.Length;
        private static readonly Random _random = new Random();

        public static string GenerarCodigo(int cantidadCaracteres = 5)
        {
            string codigo = "";

            for (int i = 0; i < cantidadCaracteres; i++)
            {
                codigo += CARACTERES[_random.Next(_cantidadCaracteres)];
            }

            return codigo;
        }
    }
}
