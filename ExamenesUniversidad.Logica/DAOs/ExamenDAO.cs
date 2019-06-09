using ExamenesUniversidad.Datos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenesUniversidad.Logica.DAOs
{
    public interface IExamenDAO : IDAO<Examen>
    {
    }

    public class ExamenDAO : DAO<Examen>, IExamenDAO
    {
    }
}
