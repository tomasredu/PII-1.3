// See https://aka.ms/new-console-template for more information
using Ej1._3;

Console.WriteLine("Hello, World!");

// Estructura con IPrecio
List<IPrecio> productos = new List<IPrecio>();

// Instaciar objetos de tipo Pack y Suelto
var p1 = new Pack(1, "Huevos", 170.32, 6);
var s1= new Suelto(2, "Jamon", 6500, 0.5);
var p2 = new Pack(3, "Gaseosa", 2100, 1);
var s2 = new Suelto(4, "Carne molida", 3000, 0.25);
var p3= new Pack(5, "Harina", 800, 3);
var s3 = new Suelto(6, "Queso", 4200, 0.2);

// Llenar productos
productos.Add(p1);
productos.Add(s1);
productos.Add(p2);
productos.Add(s2);
productos.Add(p3);
productos.Add(s3);

//Probar polimorfismo

foreach (IPrecio p in productos)
{
    Console.WriteLine(p.ToString() + "// $$$ "+ p.CalcularPrecio());
}

//
Console.ReadLine();