using Ejercicio04.Entidades;

namespace Ejercicio04.Datos
{
    public class ManejadorFlota : IFlota
    {
        private List<Moto> motos;
        public ManejadorFlota(List<Moto> motosIniciales)
        {
            motos= motosIniciales;
        }
        public void AgregarMoto(Moto moto)
        {
            if (motos.Any(m => m.Modelo == moto.Modelo))
            {
                return;
            }
            motos.Add(moto);
        }

        public (bool asignado, Moto? moto) AsignarPedido(Pedido pedido)
        {
            var motoDisponible = motos.FirstOrDefault(m => !m.EstaOcupada);
            if (motoDisponible == null)
            {
                return (false, null);
            }
            motoDisponible.AsignarPedido(pedido);
            return (true, motoDisponible);
        }

        public bool CompletarPedido(Moto moto)
        {
            if (moto.EstaOcupada)
            {
                moto.LiberarMoto();
                return true;

            }
            return false;
        }
    }
}
