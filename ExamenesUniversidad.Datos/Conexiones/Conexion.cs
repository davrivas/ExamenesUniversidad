﻿using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ExamenesUniversidad.Datos.Conexiones
{
    public static class Conexion
    {
        // Esto puede cambiar
        private const string CONEXION_STRING = @"Data Source=DESKTOP-0S26F42\SQLEXPRESS;Initial Catalog=ExamenesUniversidad;Integrated Security=True";
        public static SqlConnection ConexionObj { get; private set; } = new SqlConnection(CONEXION_STRING);

        public static void Abrir()
        {
            try
            {
                Cerrar();
                ConexionObj.Open();
                MessageBox.Show("¡Conexión exitosa!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                MessageBox.Show("ERROR: no se pudo conectar a la base de datos.\n"
                    + "Mensaje: " + ex.Message);
            }
        }

        public static void Cerrar()
        {
            try
            {
                ConexionObj.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                MessageBox.Show("ERROR: no se pudo cerrar la conexión a la base de datos.\n"
                    + "Mensaje: " + ex.Message);
            }
        }
    }
}
