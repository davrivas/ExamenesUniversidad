using ExamenesUniversidad.Datos.Entidades;
using ExamenesUniversidad.Logica.DAOs;
using ExamenesUniversidad.Logica.Utilidades;

namespace ExamenesUniversidad.Logica.Controladores.ProfesorControladores
{
    public class CrearExamenVacioControlador
    {
        private readonly IExamenDAO _examenDAO;
        private readonly ICursoDAO _cursoDAO;

        public Examen ExamenNuevo { get; set; }
        public Curso CursoAsociado { get; set; }

        public CrearExamenVacioControlador()
        {
            _examenDAO = new ExamenDAO();
            _cursoDAO = new CursoDAO();
            ExamenNuevo = new Examen();
            CursoAsociado = new Curso();
        }

        public void EncontrarCurso(string codigo)
        {
            CursoAsociado = _cursoDAO.BurcarPorCodigo(codigo);
        }

        public void AgregarExamen()
        {
            string codigoExamen;

            do
            {
                codigoExamen = StringUtilidades.GenerarCodigo();
            } while (_examenDAO.ExisteExamen(codigoExamen));

            ExamenNuevo.Codigo = codigoExamen;
            _examenDAO.Ingresar(ExamenNuevo);
            ExamenNuevo = new Examen();
        }
    }
}
