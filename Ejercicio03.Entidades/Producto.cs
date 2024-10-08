namespace Ejercicio03.Entidades
{
    public abstract class Producto
    {
        private string codigo;
        private string nombre;
        private decimal precio;

        public Producto(string codigo, string nombre, decimal precio)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.precio = precio;
        }

        public string Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public decimal Precio { get => precio; set => precio = value; }
        public abstract string MostrarInformacion();
    }
}
