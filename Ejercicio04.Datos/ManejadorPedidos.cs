using Ejercicio04.Entidades;

namespace Ejercicio04.Datos
{
    public class ManejadorPedidos : IPedidos
    {
        private Queue<Pedido> pedidosPendientes = new Queue<Pedido>();
        private int nroPedido = 0;//No hay pedidos en la cola

        public string AgregarPedido(Pedido pedido)
        {
            nroPedido++;
            pedido.Numero = nroPedido;
            pedidosPendientes.Enqueue(pedido);
            return ($"Pedido '{pedido.Descripcion}' añadido a la cola.");
        }

        public void EnviarPedido(Pedido pedido)
        {
            pedidosPendientes.Dequeue();

        }

        public Queue<Pedido> GetPedidosPendientes()
        {
            return pedidosPendientes;
        }

        public bool HayPedidosPendientes()
        {
            return pedidosPendientes.Count > 0;
        }

        public Pedido? ObtenerSiguientePedido()
        {
            if (pedidosPendientes.Count > 0)
            {
                return pedidosPendientes.Peek();
            }
            return null;
        }
    }
}
