using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1._3
{
    public abstract class Producto : IPrecio
    {
        public int codigo { get; set; }
        public string nombre { get; set; }
        public double precio { get; set; }

        public abstract double CalcularPrecio();

    }
}
