using Ejercicio04.Datos;
using Ejercicio04.Entidades;

namespace Ejercicio04.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Moto> motos = new List<Moto>
            {
                new Ciclomotor("Suzuki"),
                new Scooter("Yamaha",60),
                new MotoDeportiva("Kavasaki",110,250)
            };

            // Crear el manejador de flota con las motos disponibles
            IFlota manejadorFlota = new ManejadorFlota(motos);

            // Crear el manejador de pedidos
            IPedidos manejadorPedidos = new ManejadorPedidos();

            // Agregar algunos pedidos a la cola
            Pedido pedido1 = new Pedido("Pedido 1");
            Pedido pedido2 = new Pedido("Pedido 2");
            Pedido pedido3 = new Pedido("Pedido 3");
            Pedido pedido4 = new Pedido("Pedido 4");

            manejadorPedidos.AgregarPedido(pedido1);
            manejadorPedidos.AgregarPedido(pedido2);
            manejadorPedidos.AgregarPedido(pedido3);
            manejadorPedidos.AgregarPedido(pedido4);

            // Asignar los pedidos a las motos disponibles
            AsignarPedidos(manejadorFlota, manejadorPedidos);
            Console.WriteLine(manejadorPedidos.HayPedidosPendientes());
            // Simular que se completa un pedido
            Console.WriteLine("\n--- Finalizando un pedido ---");
            manejadorFlota.CompletarPedido(motos[0]); // Liberar la primera moto

            // Intentar asignar más pedidos
            Console.WriteLine("\n--- Asignando más pedidos ---");
            AsignarPedidos(manejadorFlota, manejadorPedidos);
        }

        private static void AsignarPedidos(IFlota manejadorFlota, IPedidos manejadorPedidos)
        {
            while (manejadorPedidos.HayPedidosPendientes())
            {
                Pedido? pedido = manejadorPedidos.ObtenerSiguientePedido();
                if (pedido is not null)
                {
                    var resultado = manejadorFlota.AsignarPedido(pedido);
                    if (resultado.asignado)
                    {
                        manejadorPedidos.EnviarPedido(pedido);
                        Console.WriteLine($"pedido nro {pedido.Numero} asignado a moto {resultado.moto!.Modelo}");
                    }
                    else
                    {
                        Console.WriteLine($"pedido nro {pedido.Numero} no asignado");
                        break;
                    }
                }

            }
        }

    }
}
