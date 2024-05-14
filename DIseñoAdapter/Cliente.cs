using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIseñoAdapter
{
    public class Cliente
    {
        private ILectorDatos _lectorDatos;

        public Cliente(ILectorDatos lectorDatos)
        {
            _lectorDatos = lectorDatos;
        }

        public void RealizarOperacionLectura()
        {
            string datos = _lectorDatos.Leer();
            Console.WriteLine("Datos leidos : " + datos);
        }
    }
}
