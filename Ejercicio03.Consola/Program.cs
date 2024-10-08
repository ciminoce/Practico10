using Ejercicio03.Datos;
using Ejercicio03.Entidades;

namespace Ejercicio03.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IAlmacen almacen = new Almacen();

            Producto alimento = new Alimento("Leche", 1.5m, "A001", DateTime.Now.AddMonths(1));
            Producto electrodomestico = new Electrodomestico("Lavadora", 300m, "E001", 24);
            Producto ropa = new Ropa("Camiseta", 20m, "R001", "M");

            almacen.AgregarProducto(alimento);
            almacen.AgregarProducto(electrodomestico);
            almacen.AgregarProducto(ropa);

            Console.WriteLine("Listado de productos en el almacén:");
            var productos = almacen.GetProductos();
            MostrarProductos(productos);
            Console.WriteLine($"Valor total de los productos en el almacén: {almacen.CalcularValorTotal()}");

            Console.WriteLine("Buscando producto por nombre 'Lavadora':");
            Producto? productoBuscado = almacen.BuscarProductoPorNombre("Lavadora");
            if (productoBuscado != null)
            {
                productoBuscado.MostrarInformacion();
            }

            Console.WriteLine("Eliminando producto con código 'A001'");
            almacen.EliminarProducto("A001");

            Console.WriteLine("Listado de productos en el almacén después de eliminar:");
            productos = almacen.GetProductos();
            MostrarProductos(productos);
        }
        public static void MostrarProductos(List<Producto> productos)
        {
            foreach (Producto producto in productos)
            {
                Console.WriteLine(producto.MostrarInformacion());
            }
        }

    }
}

