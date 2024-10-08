using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Ejercicio05.Entidades
{
    public abstract class Habitacion
    {
        public int Numero { get; set; }
        public int Capacidad { get; set; }
        public decimal PrecioPorNoche { get; set; }
        public bool Ocupada { get; set; }
        public Habitacion(int numero, int capacidad, decimal precioPorNoche)
        {
            Numero = numero;
            Capacidad = capacidad;
            PrecioPorNoche = precioPorNoche;
            Ocupada = false;
        }

        // Método virtual para mostrar información de la habitación
        public virtual string MostrarInformacion()
        {
            string estado = Ocupada ? "OCUPADA" : "LIBRE";
            return $"Habitación {Numero} - {estado} - Capacidad: {Capacidad} personas - Precio por noche: {PrecioPorNoche:C}";
        }
    }
}
