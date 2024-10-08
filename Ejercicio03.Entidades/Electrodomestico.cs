namespace Ejercicio03.Entidades
{
    public class Electrodomestico : Producto
    {
        public int GarantiaMeses { get; set; }
        public Electrodomestico(string codigo, decimal precio,string nombre,  int garantia) : base(codigo, nombre, precio)
        {
            GarantiaMeses = garantia;
        }

        public override string MostrarInformacion()
        {
            return $"Tipo:{GetType().Name} - Nombre:{Nombre} -  Precio:{Precio} - Garantía:{GarantiaMeses}";

        }
    }
}
