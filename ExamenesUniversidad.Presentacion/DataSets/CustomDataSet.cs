using ExamenesUniversidad.Datos.Entidades;
using ExamenesUniversidad.Logica.Utilidades;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenesUniversidad.Presentacion.DataSets
{
    public class CustomDataSet
    {
        private static List<Curso> _cursos;

        public static List<Curso> GetCursos()
        {
            if (_cursos == null)
            {
                _cursos = new List<Curso>
                {
                    new Curso
                    {
                        Id = 1,
                        Codigo = StringUtilidades.GenerarCodigo(),
                        Nombre = "Chompos"
                    },
                    new Curso
                    {
                        Id = 2,
                        Codigo = StringUtilidades.GenerarCodigo(),
                        Nombre = "GU"
                    },
                    new Curso
                    {
                        Id = 3,
                        Codigo = StringUtilidades.GenerarCodigo(),
                        Nombre = "Asperos"
                    }
                };
            }

            return _cursos/*.Select(x =>
            {
                dynamic obj = new ExpandoObject();
                obj.Id = x.Id;
                obj.Codigo = x.Codigo;
                obj.Nombre = x.Nombre;
                return obj;
            }).ToList()*/;
        }
    }
}
