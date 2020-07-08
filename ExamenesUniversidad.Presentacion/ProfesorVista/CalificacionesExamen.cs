using ExamenesUniversidad.Datos.DTOs.ProfesorDTOs;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using ExamenesUniversidad.Logica.Controladores.ProfesorControladores;
using ExamenesUniversidad.Logica.Utilidades;

namespace ExamenesUniversidad.Presentacion.ProfesorVista
{
    public partial class CalificacionesExamen : Form
    {
        private string _codigoExamen;
        private readonly CalificacionesExamenControlador _controlador;
        private IList<ExamenResultadoDTO> _resultadosPorExamen;

        public CalificacionesExamen()
        {
            InitializeComponent();
            _controlador = new CalificacionesExamenControlador();
            _resultadosPorExamen = new List<ExamenResultadoDTO>();
        }

        private void ButtonBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxCodigoExamen.Text))
            {
                MessageBox.Show("Debe ingresar un código");
                return;
            }

            _codigoExamen = string.Copy(textBoxCodigoExamen.Text);
            _resultadosPorExamen = _controlador.ListarResultadosPorExamen(_codigoExamen);
            dataGridViewCalificaciones.DataSource = _resultadosPorExamen;
        }

        private void ButtonPDF_Click(object sender, EventArgs e)
        {
            if (_resultadosPorExamen == null)
            {
                MessageBox.Show("No es posible generar PDF");
                return;
            }

            if (_resultadosPorExamen.Count == 0)
            {
                MessageBox.Show("No es posible generar PDF");
                return;
            }

            try
            {
                var dialogoGuardar = new SaveFileDialog();
                dialogoGuardar.FileName = $"Reporte PDF Resultados Examen {_codigoExamen} - {DateTime.Now:yyyy/MM/dd HH.mm.ss}";
                dialogoGuardar.Filter = "PDF (*.pdf)|*.pdf";
                dialogoGuardar.FilterIndex = 1;
                dialogoGuardar.RestoreDirectory = true;

                if (dialogoGuardar.ShowDialog() == DialogResult.OK)
                {
                    string rutaArchivo = dialogoGuardar.FileName;
                    
                    using (var fileStream = new FileStream(rutaArchivo, FileMode.Create, FileAccess.Write, FileShare.None))
                    {
                        using (var document = new Document(PageSize.A4))
                        {
                            document.Open();

                            var pdfTable = new PdfPTable(7);

                            pdfTable.DefaultCell.Border = 1;

                            pdfTable.AddCell("Codigo examen");
                            pdfTable.AddCell("Nombre curso");
                            pdfTable.AddCell("Nombre estudiante");
                            pdfTable.AddCell("Numero carnet");
                            pdfTable.AddCell("Cantidad bien");
                            pdfTable.AddCell("Cantidad mal");
                            pdfTable.AddCell("Total preguntas");

                            foreach (var resultado in _resultadosPorExamen)
                            {
                                pdfTable.AddCell(resultado.CodigoExamen);
                                pdfTable.AddCell(resultado.NombreCurso);
                                pdfTable.AddCell(resultado.NombreEstudiante);
                                pdfTable.AddCell(resultado.NumeroCarnet.ToString());
                                pdfTable.AddCell(resultado.CantidadBien.ToString());
                                pdfTable.AddCell(resultado.CantidadMal.ToString());
                                pdfTable.AddCell(resultado.TotalPreguntas.ToString());
                            }

                            document.Add(pdfTable);

                            document.Close();
                        }

                        fileStream.Close();
                    }

                    MessageBox.Show("Reporte hecho en " + rutaArchivo);
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
            if (_resultadosPorExamen == null)
            {
                MessageBox.Show("No es posible generar Excel");
                return;
            }

            if (_resultadosPorExamen.Count == 0)
            {
                MessageBox.Show("No es posible generar Excel");
                return;
            }

            try
            {
                var dialogoGuardar = new SaveFileDialog();
                dialogoGuardar.FileName = $"Reporte Excel {_codigoExamen} - {DateTime.Now:yyyy/MM/dd HH.mm.ss}";
                dialogoGuardar.Filter = "CSV (*.csv)|*.csv";
                dialogoGuardar.FilterIndex = 1;
                dialogoGuardar.RestoreDirectory = true;

                if (dialogoGuardar.ShowDialog() == DialogResult.OK)
                {
                    string rutaArchivo = dialogoGuardar.FileName;

                    using (var streamWriter = new StreamWriter(rutaArchivo))
                    {
                        string separador = CultureInfo.CurrentCulture.TextInfo.ListSeparator;

                        string encabezado = "Codigo examen" +
                                            $"{separador}Nombre curso" +
                                            $"{separador}Nombre estudiante" +
                                            $"{separador}Numero carnet" +
                                            $"{separador}Cantidad bien" +
                                            $"{separador}Cantidad mal" +
                                            $"{separador}Total preguntas";
                        streamWriter.WriteLine(encabezado);

                        foreach (var resultado in _resultadosPorExamen)
                        {
                            string fila = $"{resultado.CodigoExamen}" +
                                          $"{separador}{resultado.NombreCurso}" +
                                          $"{separador}{resultado.NombreEstudiante}" +
                                          $"{separador}{resultado.NumeroCarnet}" +
                                          $"{separador}{resultado.CantidadBien}" +
                                          $"{separador}{resultado.CantidadMal}" +
                                          $"{separador}{resultado.TotalPreguntas}";
                            streamWriter.WriteLine(fila);
                        }

                        streamWriter.Close();
                    }

                    MessageBox.Show("Excel creado con éxito en " + rutaArchivo);
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
