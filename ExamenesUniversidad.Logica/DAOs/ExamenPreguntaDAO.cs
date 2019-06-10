using ExamenesUniversidad.Datos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenesUniversidad.Logica.DAOs
{
    public interface IExamenPreguntaDAO : IDAO<ExamenPregunta>
    {
    }

    public class ExamenPreguntaDAO : DAO<ExamenPregunta>, IExamenPreguntaDAO
    {
    }
}
