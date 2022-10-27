using Models;

namespace Oficina
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pneu pneu = new Pneu(14, "Pirelli");
            pneu.Girar(5);
            pneu.Girar(950);
            pneu.Frear(900);
            pneu.Exibir();
        }
    }
}