using Ejercicio05.Datos;
using Ejercicio05.Entidades;

namespace Ejercicio05.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IHotel hotel = new Hotel();

            // Agregar habitaciones de diferentes tipos
            Console.WriteLine(hotel.AgregarHabitacion(new HabitacionSimple(101, 50m)));
            Console.WriteLine(hotel.AgregarHabitacion(new HabitacionDoble(202, 80m)));
            Console.WriteLine(hotel.AgregarHabitacion(new Suite(303, 150m, "Jacuzzi, Desayuno Incluido")));
            Console.WriteLine(hotel.AgregarHabitacion(new HabitacionSimple(102, 50m)));
            Console.WriteLine(hotel.AgregarHabitacion(new HabitacionDoble(203, 80m)));
            Console.WriteLine(hotel.AgregarHabitacion(new Suite(304, 150m, "Jacuzzi, Desayuno Incluido")));

            // Listar todas las habitaciones
            Console.WriteLine("\n--- Habitaciones ---");
            foreach (var habitacion in hotel.ListarHabitaciones())
            {
                Console.WriteLine(habitacion.MostrarInformacion());
            }


            // Buscar una habitación por número
            Console.WriteLine("\n--- Buscar habitación por número ---");
            var habitacionBuscada = hotel.BuscarPorNumero(202);
            if (habitacionBuscada != null)
            {
                Console.WriteLine(habitacionBuscada.MostrarInformacion());
            }
            else
            {
                Console.WriteLine("Habitación no encontrada.");
            }

            // Buscar habitaciones por tipo (Suite)
            Console.WriteLine("\n--- Buscar habitaciones por tipo (Suite) ---");
            var habitacionesSuite = hotel.BuscarPorTipo(typeof(Suite));

            if (habitacionesSuite is not null)
            {
                foreach (var habitacion in habitacionesSuite)
                {
                    Console.WriteLine(habitacion.MostrarInformacion());
                }

            } 

        }
    }
}
