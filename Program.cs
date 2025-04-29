using System;
using tallerClase;

namespace MiAplicacion
{
    class Program
    {
        static void Main(string[] args)
        {

            //List<Producto> productos = new List<Producto>
            //{
            //    new Producto { Id = 1, Nombre = "Laptop HP", Categoria = "Electrónica", Precio = 3500, Stock = 10, ProveedorId = 1 },
            //    new Producto { Id = 2, Nombre = "Mouse Logitech", Categoria = "Electrónica", Precio = 150, Stock = 50, ProveedorId = 2 },
            //    new Producto { Id = 3, Nombre = "Silla de Oficina", Categoria = "Muebles", Precio = 800, Stock = 5, ProveedorId = 3 },
            //    new Producto { Id = 4, Nombre = "Cafetera Oster", Categoria = "Electrodomésticos", Precio = 600, Stock = 0, ProveedorId = 4 },
            //    new Producto { Id = 5, Nombre = "Escritorio Moderno", Categoria = "Muebles", Precio = 1200, Stock = 7, ProveedorId = 3 },
            //    new Producto { Id = 6, Nombre = "Monitor Samsung", Categoria = "Electrónica", Precio = 2500, Stock = 8, ProveedorId = 1 },
            //    new Producto { Id = 7, Nombre = "Teclado Mecánico", Categoria = "Electrónica", Precio = 400, Stock = 15, ProveedorId = 2 },
            //    new Producto { Id = 8, Nombre = "Aspiradora LG", Categoria = "Electrodomésticos", Precio = 1100, Stock = 2, ProveedorId = 4 }
            //};
            //List<Proveedor> proveedores = new List<Proveedor>
            //{
            //    new Proveedor { Id = 1, Nombre = "TechSupply" },
            //    new Proveedor { Id = 2, Nombre = "Accesorios PC" },
            //    new Proveedor { Id = 3, Nombre = "Muebles XYZ" },
            //    new Proveedor { Id = 4, Nombre = "ElectroHome" }
            //};
            //var productosDisponibles = from p in productos
            //                           where p.Stock > 0
            //                           select p;
            //foreach (var producto in productosDisponibles)
            //{
            //    Console.WriteLine($"Producto: {producto.Nombre}, Stock: {producto.Stock}");
            //}
            //productosDisponibles.ToList().ForEach(producto => Console.WriteLine(producto.Nombre));       

            //var productosOrdenados = from p in productos
            //                         orderby p.Nombre
            //                         select p;
            //productosOrdenados.ToList().ForEach(producto => Console.WriteLine(producto.Nombre));
            Random rnd = new();
            var productosConEtiquetas = new List<(string Producto, List<string> Etiquetas)>
            {
                ("Laptop HP", new List<string> { "Electrónica", "Computadores", "Trabajo" }),
                ("Silla de Oficina", new List<string> { "Muebles", "Confort", "Oficina" }),
                ("Cafetera Oster", new List<string> { "Cocina", "Electrodomésticos", "Café" })
            };

            int mindex = rnd.Next(productosConEtiquetas.Count);
            var productoAleatorio = productosConEtiquetas[mindex];
            string randomLabel = productoAleatorio.Etiquetas[rnd.Next(productoAleatorio.Etiquetas.Count)];

            Console.WriteLine($"Producto aleatorio: {productoAleatorio.Producto}\n");

            var todasEtiquetas = productosConEtiquetas.SelectMany(p => p.Etiquetas).Distinct().ToList();
            foreach (var etiqueta in todasEtiquetas)
            {
                Console.WriteLine($"\t{etiqueta}\n");
            }
            Console.WriteLine($"Escriba una etiqueta: \n");
            string userOption = Console.ReadLine().ToUpper();

            if (userOption == randomLabel.ToUpper())
            {
                Console.WriteLine("¡Felicitaciones! Has acertado.");
            }
            else
            {
                Console.WriteLine($"Respuesta incorrecta. La etiqueta era: { randomLabel}");
            }
        }
    }
}
