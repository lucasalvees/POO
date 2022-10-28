using Models;

namespace Oficina
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pneu pneu = new Pneu(14, "Pirelli");
            //pneu.Girar(5);
            //pneu.Girar(950);
            //pneu.Frear(900);
            //pneu.Exibir();

            Carro corcel = new Carro("Ford", "2");
            corcel.LigarDesligar();
            for (int i = 0; i < 120; i++)
            {
                corcel.Acelerar(22);
                corcel.Frear(19);
            }
            //corcel.LigarDesligar();
            //corcel.PneuTraseiroDireito = pneu;
            //corcel.PneuTraseiroEsquerdo = pneu;
            corcel.Exibir();

        }
    }
}