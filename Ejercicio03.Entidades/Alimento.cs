namespace Ejercicio03.Entidades
{
    public class Alimento : Producto
    {
        public DateTime FechaVencimiento { get; set; }
        public Alimento(string codigo, decimal precio, string nombre,  DateTime fechaVto) : base(codigo, nombre, precio)
        {
            FechaVencimiento = fechaVto;
        }

        public override string MostrarInformacion()
        {
            return $"Tipo:{GetType().Name} - Nombre:{Nombre} -  Precio:{Precio} - Vencimiento:{FechaVencimiento.ToShortDateString()}";
        }
    }
}
