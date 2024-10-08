namespace Ejercicio04.Entidades
{
    public class Pedido
    {
        public string Descripcion { get; set; } = null!;
        public int Numero { get; set; }
        public Pedido(string descripcion)
        {
            Descripcion = descripcion;
        }
    }
}
