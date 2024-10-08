namespace Ejercicio04.Entidades
{
    public class Scooter : Moto
    {
        public Scooter(string modelo, int cilindrada) : base(modelo, cilindrada)
        {
            if (cilindrada > 90)
            {
                throw new ArgumentException("Demasiada cilindrada para Scooter!!!");
            }
        }
    }

}
