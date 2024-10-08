namespace Ejercicio03.Entidades
{
    public class Ropa : Producto
    {
        public string Talle { get; set; } = null!;
        public Ropa(string codigo, decimal precio, string nombre,  string talle) : base(codigo, nombre, precio)
        {
            Talle = talle;
        }

        public override string MostrarInformacion()
        {
            return $"Tipo:{GetType().Name} - Nombre:{Nombre} - Talle:{Talle} - Precio:{Precio}";
        }
    }
}
