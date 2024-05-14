using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIseñoAdapter
{
    public class LectorDatos : ILectorDatos
    {
        public string Leer()
        {
            return "DATOS LEIDOS DE LA FUENTE ORIGINAL";
        }
    }
}
