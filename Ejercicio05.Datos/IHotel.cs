using Ejercicio05.Entidades;

namespace Ejercicio05.Datos
{
    public interface IHotel
    {
        string AgregarHabitacion(Habitacion habitacion);
        string EliminarHabitacion(int numero);
        Habitacion? BuscarPorNumero(int numero);
        List<Habitacion>? BuscarPorTipo(Type type);
        List<Habitacion> ListarHabitaciones();
        string ReservarHabitacion(int numero,DateTime fechaEntrada, DateTime fechaSalida);
        string EliminarReserva(Reserva reserva);
        List<Reserva> ListarReservas();
        bool BuscarHabitacionDisponible(int  numero);
    }
}
