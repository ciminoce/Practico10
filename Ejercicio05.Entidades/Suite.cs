namespace Ejercicio05.Entidades
{
    // Clase derivada Suite
    public class Suite : Habitacion
    {
        public string ServiciosAdicionales { get; set; }

        public Suite(int numero, decimal precioPorNoche, string serviciosAdicionales)
            : base(numero, 4, precioPorNoche)
        {
            ServiciosAdicionales = serviciosAdicionales;
        }

        public override string MostrarInformacion()
        {
            return base.MostrarInformacion() + $" - Tipo: Suite - Servicios: {ServiciosAdicionales}";
        }
    }
}
