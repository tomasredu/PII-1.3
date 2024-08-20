using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1._3
{
    public class Pack : Producto
    {
        public int cantidad { get; set; }
        public Pack() 
        { 
            this.cantidad = 0;
            this.nombre = "";
            this.codigo = 0;
            this.precio = 0;
        }

        public Pack(int codigo, string nombre, double precio, int cantidad)
        {
            this.nombre = nombre;
            this.codigo = codigo;
            this.precio = precio;
            this.cantidad = cantidad;
        }

        public override double CalcularPrecio()
        {
            double importe = cantidad * precio;
            return importe;
        }

        public override string ToString()
        {
            return nombre + " - Cant:" + cantidad + " - $ x Cant:" + precio;
        }
    }
}
