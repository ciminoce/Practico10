
namespace Ejercicio04.Entidades
{
    public abstract class Moto
    {
        public string Modelo { get; private set; }
        public int Cilindrada { get; set; }
        public bool EstaOcupada { get; private set; }
        public Pedido? PedidoActual { get; private set; }

        public Moto(string modelo, int cilindrada)
        {
            Modelo = modelo;
            Cilindrada = cilindrada;
            EstaOcupada = false;
        }

        public string AsignarPedido(Pedido pedido)
        {
            PedidoActual = pedido;
            EstaOcupada = true;
            return ($"{Modelo} asignada al pedido {pedido.Descripcion}.");
        }

        public string LiberarMoto()
        {
            PedidoActual=null;
            EstaOcupada=false;
            return ($"{Modelo} entrego al pedido");
        }
    }
}
