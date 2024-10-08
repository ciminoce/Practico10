using Ejercicio05.Entidades;

namespace Ejercicio05.Datos
{
    public class Hotel : IHotel
    {
        private List<Habitacion> habitaciones = new List<Habitacion>();
        private List<Reserva> reservasEfectuadas=new List<Reserva>();

        public Hotel()
        {
            habitaciones=new List<Habitacion>();  
            reservasEfectuadas = new List<Reserva>();
        }
        public Hotel(string nombre):this()
        {
            Nombre = nombre;
        }

        public string Nombre { get; set; } = null!;
        public string AgregarHabitacion(Habitacion habitacion)
        {
            habitaciones.Add(habitacion);
            return ($"Habitación {habitacion.Numero} agregada a la reserva.");
        }
       
        public string EliminarHabitacion(int numero)
        {
            Habitacion? habitacion = habitaciones.Find(h => h.Numero == numero);
            if (habitacion != null)
            {
                habitaciones.Remove(habitacion);
                return ($"Habitación {numero} eliminada de la reserva.");
            }
            else
            {
                return ($"No se encontró la habitación {numero} en la reserva.");
            }
        }

        public List<Habitacion> ListarHabitaciones()
        {
            return habitaciones;
        }


        public Habitacion? BuscarPorNumero(int numero)
        {
            return habitaciones.Find(h => h.Numero == numero);
        }

        public List<Habitacion> BuscarPorTipo(Type tipo)
        {
            return habitaciones.FindAll(h => h.GetType() == tipo);
        }

        public (bool,Habitacion?) BuscarHabitacionDisponible(int numero)
        {
            var habitacion = BuscarPorNumero(numero);
            if (habitacion is not null)
            {
                return (habitacion.Ocupada,habitacion);
            }
            return (false, null);
        }

        public string ReservarHabitacion(int numero, DateTime fechaEntrada, DateTime fechaSalida)
        {
            var (disponible, habitacion)=BuscarHabitacionDisponible(numero);
            if (!disponible)
            {
                if (habitacion is not null)
                {
                    return $"{habitacion!.Numero} se encuentra ocupada";

                }
                else
                {
                    return $"{habitacion!.Numero} no existe!!!";
                }
            }
            else
            {
                Reserva reserva = new Reserva(habitacion,fechaEntrada,fechaSalida);
                habitacion.Ocupada = true;
                return $"{habitacion!.Numero} reservada!!!";
            }
        }

        public string EliminarReserva(Reserva reserva)
        {
            var habitacionReservada = reserva.Habitacion;
            reservasEfectuadas.Remove(reserva);
            habitacionReservada!.Ocupada = false;
            return $"Se liberó habitación {habitacionReservada.Numero}";
        }

        public List<Reserva> ListarReservas()
        {
            return reservasEfectuadas;
        }
    }
}
