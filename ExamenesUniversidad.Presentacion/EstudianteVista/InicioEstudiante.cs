using ExamenesUniversidad.Datos.DTOs.EstudianteDTOs;
using ExamenesUniversidad.Logica.Controladores.EstudianteControladores;
using ExamenesUniversidad.Presentacion.DataSets;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using ExamenesUniversidad.Logica.Utilidades;

namespace ExamenesUniversidad.Presentacion.EstudianteVista
{
    public partial class InicioEstudiante : Form
    {
        private readonly InicioEstudianteControlador _controlador;
        private IList<EstudianteResultadoDTO> _resultados;

        public InicioEstudiante()
        {
            InitializeComponent();
            _controlador = new InicioEstudianteControlador();
            ActualizarExamenes();
            ActualizarCalificaciones();
        }

        public void ActualizarExamenes()
        {
            dataGridViewExamenes.DataSource = EstudianteDataSet.GetExamenes();
        }

        private void ActualizarCalificaciones()
        {
            _resultados = EstudianteDataSet.ListarResultados();
            dataGridViewCalificaciones.DataSource = _resultados;
        }

        private void ButtonCerrarSesion_Click(object sender, EventArgs e)
        {
            Program.InicioForm.Show();
            Close();
        }

        private void ButtonRefrescar_Click(object sender, EventArgs e)
        {
            ActualizarExamenes();
        }

        private void ButtonRealizarExamen_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxCodigoExamen.Text))
            {
                _controlador.BuscarExamen(textBoxCodigoExamen.Text);

                if (_controlador.ExamenBuscado != null)
                {
                    if (_controlador.ExamenBuscado.Abierto)
                    {
                        var controlador = new RealizarExamenControlador(textBoxCodigoExamen.Text);
                        var formulario = new RealizarExamen(controlador);
                        formulario.Show();
                    }
                    else
                    {
                        MessageBox.Show($"El examen está {textBoxCodigoExamen.Text} cerrado", "Error");
                    }
                }
                else
                {
                    MessageBox.Show($"El examen {textBoxCodigoExamen.Text} no existe", "Error");
                }
            }
            else
            {
                MessageBox.Show("Digite el código del examen", "Error");
            }
        }

        private void ButtonRefrescarCalificaciones_Click(object sender, EventArgs e)
        {
            ActualizarCalificaciones();
        }

        private void ButtonPDF_Click(object sender, EventArgs e)
        {
            try
            {
                var dialogoGuardar = new SaveFileDialog();
                dialogoGuardar.Filter = "PDF (*.pdf)|*.pdf";
                dialogoGuardar.FilterIndex = 1;
                dialogoGuardar.RestoreDirectory = true;

                if (dialogoGuardar.ShowDialog() == DialogResult.OK)
                {
                    string rutaDeArchivo = dialogoGuardar.FileName;

                    using (var fileStream = new FileStream(rutaDeArchivo, FileMode.Create, FileAccess.Write, FileShare.None))
                    {
                        using (var document = new Document(PageSize.A4))
                        {
                            document.Open();

                            var pdfTable = new PdfPTable(6);

                            pdfTable.DefaultCell.Border = 1;

                            pdfTable.AddCell("Codigo examen");
                            pdfTable.AddCell("Nombre curso");
                            pdfTable.AddCell("Nombre profesor");
                            pdfTable.AddCell("Cantidad bien");
                            pdfTable.AddCell("Cantidad mal");
                            pdfTable.AddCell("Total preguntas");

                            foreach (var resultado in _resultados)
                            {
                                pdfTable.AddCell(resultado.CodigoExamen);
                                pdfTable.AddCell(resultado.NombreCurso);
                                pdfTable.AddCell(resultado.NombreProfesor);
                                pdfTable.AddCell(resultado.CantidadBien.ToString());
                                pdfTable.AddCell(resultado.CantidadMal.ToString());
                                pdfTable.AddCell(resultado.TotalPreguntas.ToString());
                            }

                            document.Add(pdfTable);

                            document.Close();
                        }

                        fileStream.Close();
                    }

                    MessageBox.Show("Reporte hecho en " + rutaDeArchivo);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void ButtonExcel_Click(object sender, EventArgs e)
        {
            try
            {
                var dialogoGuardar = new SaveFileDialog();
                dialogoGuardar.Filter = "CSV (*.csv)|*.csv";
                dialogoGuardar.FilterIndex = 1;
                dialogoGuardar.RestoreDirectory = true;

                if (dialogoGuardar.ShowDialog() == DialogResult.OK)
                {
                    string rutaDeArchivo = dialogoGuardar.FileName;

                    using (var streamWriter = new StreamWriter(rutaDeArchivo))
                    {
                        string separador = CultureInfo.CurrentCulture.TextInfo.ListSeparator;

                        string encabezado = "Codigo examen" +
                            $"{separador}Nombre curso" +
                            $"{separador}Nombre profesor" +
                            $"{separador}Cantidad bien" +
                            $"{separador}Cantidad mal" +
                            $"{separador}Total preguntas";
                        streamWriter.WriteLine(encabezado);

                        foreach (var resultado in _resultados)
                        {
                            string fila = $"{resultado.CodigoExamen}" +
                                $"{separador}{resultado.NombreCurso}" +
                                $"{separador}{resultado.NombreProfesor}" +
                                $"{separador}{resultado.CantidadBien}" +
                                $"{separador}{resultado.CantidadMal}" +
                                $"{separador}{resultado.TotalPreguntas}";
                            streamWriter.WriteLine(fila);
                        }

                        streamWriter.Close();
                    }

                    MessageBox.Show("Excel creado con éxito en " + rutaDeArchivo);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
