using System;
using System;
using System.Collections.Generic;
using System.Text;

namespace E_Commerce
{
    internal class Producto
    {
        public string Nombre { get; private set; }
        public decimal Precio { get; private set; }
        public int Cantidad { get; private set; }

        public decimal Subtotal
        {
            get { return Precio * Cantidad; }
        }

        public Producto(string nombre, decimal precio, int cantidad)
        {
            Nombre = nombre;
            Precio = precio;
            Cantidad = cantidad;
        }

        public void MostrarProducto()
        {
            Console.WriteLine($"Producto: {Nombre} | Subtotal: {Subtotal}");
        }
    }
}