using ExamenesUniversidad.Datos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenesUniversidad.Logica.DAOs
{
    public interface IEstudianteRespuestaDAO : IDAO<EstudianteRespuesta>
    {
    }

    public class EstudianteRespuestaDAO : DAO<EstudianteRespuesta>, IEstudianteRespuestaDAO
    {
    }
}
