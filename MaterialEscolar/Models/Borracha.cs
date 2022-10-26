namespace Models
{
    public class Borracha
    {
		private string cor;
		private string marca;
		private int percentualBorracha;

		public string Marca
		{
			get { return marca; }
			set { marca = value; }
		}
		public string Cor
		{
			get { return cor; }
			set { cor = value; }
		}
		public int PercentualBorracha
		{
			get { return percentualBorracha; }
			set { percentualBorracha = value; }
		}

		public Borracha(string _cor, string _marca)
		{
			Cor = _cor;
			Marca = _marca;
			PercentualBorracha = 100;
		}

		public void Apagar()
		{
			PercentualBorracha -= 10;
		}

		public void Exibir()
		{
            Console.WriteLine("Cor: " + Cor);
            Console.WriteLine("Marca: " + Marca);
            Console.WriteLine("Percentual da Borracha: " + PercentualBorracha);
        }
	}
}
