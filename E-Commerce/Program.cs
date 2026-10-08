namespace E_Commerce
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carrito carrito = new Carrito();
            string respuesta = "";

            do
            {
                Console.WriteLine("¿Deseas agregar un producto al carrito? (si/no)");
                respuesta = Console.ReadLine().ToLower();

                switch (respuesta)
                {
                    case "si":
                        Console.WriteLine("¿Cuál es el nombre del producto?");
                        string nombre = Console.ReadLine();

                        Console.WriteLine("¿Cuál es el precio del producto?");
                        decimal precio = decimal.Parse(Console.ReadLine());

                        Console.WriteLine("¿Cuál es la cantidad del producto?");
                        int cantidad = int.Parse(Console.ReadLine());

                        Producto producto = new Producto(nombre, precio, cantidad);
                        carrito.AgregarProducto(producto);
                        break;

                    case "no":
                        Console.WriteLine("Cerrando el carrito...");
                        break;

                    default:
                        Console.WriteLine("Respuesta no válida. Escribe 'si' o 'no'.");
                        Console.WriteLine();
                        break;
                }

            } while (respuesta != "no");

            carrito.MostrarTotal();
            Console.WriteLine("Presiona ENTER para salir...");
            Console.ReadLine();
        }
    }
}