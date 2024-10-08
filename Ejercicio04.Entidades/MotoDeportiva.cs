namespace Ejercicio04.Entidades
{
    public class MotoDeportiva : Moto
    {
        public int VelocidadMaxima { get; set; }
        public MotoDeportiva(string modelo, int cilindrada, int velocidad) : base(modelo, cilindrada)
        {
            Cilindrada = cilindrada;
            VelocidadMaxima = velocidad;
        }
    }

}
