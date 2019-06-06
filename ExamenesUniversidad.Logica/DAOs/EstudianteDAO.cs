using ExamenesUniversidad.Datos.Entidades;
using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace ExamenesUniversidad.Logica.DAOs
{
    public interface IEstudianteDAO : IDAO<Estudiante>
    {
        bool ExisteEstudiante(string usuario, string clave);
    }

    public class EstudianteDAO : DAO<Estudiante>, IEstudianteDAO
    {
        public bool ExisteEstudiante(string usuario, string clave)
        {
            try
            {
                var estudiante = Listar().Where(x => x.NombreUsuario == usuario && x.Clave == clave).AsQueryable().FirstOrDefault();
                bool validacion = estudiante != null;

                if (!validacion)
                    MessageBox.Show($"No se encontró al estudiante '{usuario}'", "Error");

                return validacion;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.StackTrace);
                MessageBox.Show($"Ocurrio un error: " + ex.Message, "Error");
                return false;
            }
        }
    }
}
