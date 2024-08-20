using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1._3
{
    public class Suelto : Producto
    {
        public double medida { get; set; }

        public Suelto()
        {
            this.medida = 0;
            this.nombre = "";
            this.codigo = 0;
            this.precio = 0;
        }

        public Suelto(int codigo, string nombre, double precio, double medida)
        {
            this.nombre = nombre;
            this.codigo = codigo;
            this.precio = precio;
            this.medida = medida;
        }

        public override double CalcularPrecio()
        {
            double importe = precio * medida;
            return importe;
        }

        public override string ToString()
        {
            return nombre + " - Md:" + medida + " - $ x Md:" + precio;
        }

    }
}
