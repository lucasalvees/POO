using Models;
internal class Program
{
    private static void Main(string[] args)
    {
        Caneta caneta = new Caneta("Azul", "Bic", "Plástico");
        caneta.Escrever("Lab 02");
        caneta.Exibir();

        Lapis lapis = new Lapis("2B");
        lapis.QuebrarPonta();
        lapis.Escrever("OI");

        Apontador apontador = new Apontador("Vermelho", "Faber Castell", "Plástico");
        apontador.Apontar();
        apontador.Apontar();
        apontador.Apontar();
        apontador.Apontar();
        apontador.Apontar();
        apontador.Apontar();
        apontador.Apontar();
        apontador.Apontar();
        apontador.Apontar();
        apontador.Apontar();
        apontador.Apontar();
        apontador.Esvaziar();
        apontador.Apontar();
        apontador.Exibir();

        Caderno caderno = new Caderno("Tilibra");
        caderno.ArrancarFolha();
        caderno.Exibir();
    }
}