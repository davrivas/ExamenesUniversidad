using ExamenesUniversidad.Datos.DTOs.ProfesorDTOs;
using ExamenesUniversidad.Presentacion.DataSets;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenesUniversidad.Presentacion.ProfesorVista
{
    public partial class CalificacionesExamen : Form
    {
        private IList<ExamenResultadoDTO> _resultadosPorExamen;

        public CalificacionesExamen()
        {
            InitializeComponent();
            _resultadosPorExamen = new List<ExamenResultadoDTO>();
        }

        private void ButtonBuscar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxCodigoExamen.Text))
            {
                _resultadosPorExamen = ProfesorDataSet.ListarResultadosPorExamen(textBoxCodigoExamen.Text);
                
            }
            else
            {
                _resultadosPorExamen = new List<ExamenResultadoDTO>();
            }

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
                string outputFile = @"C:\Users\davr\Desktop\CalificacionesPorExamen.pdf";

                using (var fileStream = new FileStream(outputFile, FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    using (var document = new Document(PageSize.A4))
                    {
                        using (var writer = PdfWriter.GetInstance(document, fileStream))
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
                    }

                    fileStream.Close();
                }

                MessageBox.Show("Reporte hecho en " + outputFile);
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
                string outputFile = @"C:\Users\davr\Desktop\CalificacionesPorExamen.csv";

                using (var streamWriter = new StreamWriter(outputFile))
                {
                    string encabezado = $"Codigo examen" +
                        $";Nombre curso" +
                        $";Nombre estudiante" +
                        $";Numero carnet" +
                        $";Cantidad bien" +
                        $";Cantidad mal" +
                        $";Total preguntas";
                    streamWriter.WriteLine(encabezado);

                    foreach (var resultado in _resultadosPorExamen)
                    {
                        string fila = $"{resultado.CodigoExamen}" +
                            $";{resultado.NombreCurso}" +
                            $";{resultado.NombreEstudiante}" +
                            $";{resultado.NumeroCarnet.ToString()}" +
                            $";{resultado.CantidadBien.ToString()}" +
                            $";{resultado.CantidadMal.ToString()}" +
                            $";{resultado.TotalPreguntas.ToString()}";
                        streamWriter.WriteLine(fila);
                    }

                    streamWriter.Close();
                }

                MessageBox.Show("Excel creado con éxito en " + outputFile);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
