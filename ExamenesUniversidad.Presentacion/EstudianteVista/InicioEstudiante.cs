using ExamenesUniversidad.Datos.DTOs.EstudianteDTOs;
using ExamenesUniversidad.Logica.Controladores.EstudianteControladores;
using ExamenesUniversidad.Presentacion.DataSets;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

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
                //This is the absolute path to the PDF that we will create
                string outputFile = @"C:\Users\davr\Desktop\CalificacionesEstudiante.pdf";

                //Create a standard .Net FileStream for the file, setting various flags
                using (var fileStream = new FileStream(outputFile, FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    //Create a new PDF document setting the size to A4
                    using (var document = new Document(PageSize.A4))
                    {
                        //Bind the PDF document to the FileStream using an iTextSharp PdfWriter
                        using (var writer = PdfWriter.GetInstance(document, fileStream))
                        {
                            //Open the document for writing
                            document.Open();

                            //Create a table with two columns
                            var pdfTable = new PdfPTable(6);

                            //Borders are drawn by the individual cells, not the table itself.
                            //Tell the default cell that we do not want a border drawn
                            pdfTable.DefaultCell.Border = 1;

                            //Add cells. Cells are added starting at the top left of the table working left to right first, then down
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

                            //Add the table to our document
                            document.Add(pdfTable);

                            //Close our document
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
    }
}
