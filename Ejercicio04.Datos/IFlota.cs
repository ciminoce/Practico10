using Ejercicio04.Entidades;

namespace Ejercicio04.Datos
{
    public interface IFlota
    {
        void AgregarMoto(Moto moto);
        (bool asignado, Moto? moto) AsignarPedido(Pedido pedido);
        bool CompletarPedido(Moto moto);
    }

}
