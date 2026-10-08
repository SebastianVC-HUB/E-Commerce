using System;
using System.Collections.Generic;
using System.Text;

namespace E_Commerce
{
    internal class Carrito
    {
        public decimal Total { get; private set; }
        public int CantidadProductos { get; private set; }

        public Carrito()
        {
            Total = 0;
            CantidadProductos = 0;
        }

        public void AgregarProducto(Producto producto)
        {
            Total = Total + producto.Subtotal;
            CantidadProductos = CantidadProductos + 1;

            producto.MostrarProducto();
            Console.WriteLine($"Total acumulado: {Total}");
            Console.WriteLine();
        }

        public void MostrarTotal()
        {
            Console.WriteLine();
            Console.WriteLine($"Cantidad de productos agregados: {CantidadProductos}");
            Console.WriteLine($"TOTAL A PAGAR: {Total}");
        }
    }
}