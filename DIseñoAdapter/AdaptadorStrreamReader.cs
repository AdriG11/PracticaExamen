using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIseñoAdapter
{
    public class AdaptadorStrreamReader : ILectorDatos
    {
        private StreamReader _stream;

        public AdaptadorStrreamReader (StreamReader stream)
        {
            _stream = stream;
        }

        public string Leer()
        {
            return _stream.ReadLine();
        }
    }
}
