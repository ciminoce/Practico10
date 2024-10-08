namespace Ejercicio05.Entidades
{
    // Clase derivada HabitacionDoble
    public class HabitacionDoble : Habitacion
    {
        public HabitacionDoble(int numero, decimal precioPorNoche)
            : base(numero, 2, precioPorNoche) { }

        public override string MostrarInformacion()
        {
            return base.MostrarInformacion() + " - Tipo: Doble";
        }
    }
}
