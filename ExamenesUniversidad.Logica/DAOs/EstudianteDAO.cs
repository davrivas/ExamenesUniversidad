using ExamenesUniversidad.Datos.Entidades;
using ExamenesUniversidad.Logica.Utilidades;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ExamenesUniversidad.Logica.DAOs
{
    public interface IEstudianteDAO : IDAO<Estudiante>
    {
        bool ExisteEstudiante(string usuario, string clave);
        bool ExisteEstudiante(string usuario);
    }

    public class EstudianteDAO : DAO<Estudiante>, IEstudianteDAO
    {
        public bool ExisteEstudiante(string usuario, string clave)
        {
            try
            {
                var estudiante = Listar()
                    .FirstOrDefault(x => x.NombreUsuario == usuario && x.Clave == clave);
                bool validacion = estudiante != null;

                if (!validacion)
                    MessageBox.Show($"No se encontró al estudiante '{usuario}'", "Error");
                else
                    Sesion.Estudiante = estudiante;

                return validacion;
            }
            catch (Exception ex)
            {
                ExcepcionUtilidades.DebugWriteLineMessageBoxShowExcepcion(ex);
                return false;
            }
        }

        public bool ExisteEstudiante(string usuario)
        {
            try
            {
                var estudiante = Listar()
                    .FirstOrDefault(x => x.NombreUsuario == usuario);
                bool validacion = estudiante != null;

                return validacion;
            }
            catch (Exception ex)
            {
                ExcepcionUtilidades.DebugWriteLineMessageBoxShowExcepcion(ex);
                return false;
            }
        }
    }
}
