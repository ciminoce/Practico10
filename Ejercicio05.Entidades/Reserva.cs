namespace Ejercicio05.Entidades
{
    public class Reserva
    {
        public Reserva(Habitacion? habitacion, DateTime? entrada, DateTime? salida)
        {
            Habitacion = habitacion;
            Entrada = entrada;
            Salida = salida;
        }

        public Habitacion? Habitacion { get; set; }
        public DateTime? Entrada { get; set; }
        public DateTime? Salida { get; set; }
    }
}
