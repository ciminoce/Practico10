using Ejercicio04.Entidades;

namespace Ejercicio04.Datos
{
    public interface IPedidos
    {
        Queue<Pedido> GetPedidosPendientes();
        string AgregarPedido(Pedido pedido);
        Pedido? ObtenerSiguientePedido();
        bool HayPedidosPendientes();
        void EnviarPedido(Pedido pedido);
    }

}
