using ExamenesUniversidad.Datos.Entidades;
using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace ExamenesUniversidad.Logica.DAOs
{
    public interface IProfesorDAO : IDAO<Profesor>
    {
        bool ExisteProfesor(string usuario, string clave);
    }

    public class ProfesorDAO : DAO<Profesor>, IProfesorDAO
    {
        public bool ExisteProfesor(string usuario, string clave)
        {
            try
            {
                var profesor = Listar().Where(x => x.NombreUsuario == usuario && x.Clave == clave).AsQueryable().FirstOrDefault();
                bool validacion = profesor != null;

                if (!validacion)
                    MessageBox.Show($"No se encontró al profesor '{usuario}'", "Error");

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
