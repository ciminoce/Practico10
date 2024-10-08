namespace Ejercicio05.Entidades
{
    // Clase derivada HabitacionSimple
    public class HabitacionSimple : Habitacion
    {
        public HabitacionSimple(int numero, decimal precioPorNoche)
            : base(numero, 1, precioPorNoche) { }

        public override string MostrarInformacion()
        {
            return base.MostrarInformacion() + " - Tipo: Simple";
        }
    }
}
