namespace Models
{
    public class Lapis
    {
		private string dureza;
		private bool apontado;
		private int percentualGrafite;

		public string Dureza
		{
			get { return dureza; }
			set { dureza = value; }
		}
		public bool Apontado
		{
			get { return apontado; }
			set { apontado = value; }
		}
		public int PercentualGrafite
		{
			get { return percentualGrafite; }
			set { percentualGrafite = value; }
		}

		public Lapis(string _dureza)
		{
			Dureza = _dureza;
			Apontado = true;
			PercentualGrafite = 100;
		}

		public void QuebrarPonta()
		{
            if (PercentualGrafite < 15)
            {
                Console.WriteLine("Compre outro lápis.");
                return;
            }
            apontado = false;
			GastarPonta(15);
		}

		public void Apontar()
		{
			if (PercentualGrafite < 5)
			{
				Console.WriteLine("Compre outro lápis.");
				return;
			}
			apontado = true;
            GastarPonta(5);
        }

		private void GastarPonta(int _percentual)
		{
			PercentualGrafite -= _percentual;
			if (PercentualGrafite < 0)
				PercentualGrafite = 0;
		}

		public void Escrever(string _texto)
		{
			if (PercentualGrafite < 10)
			{
				Console.WriteLine("Compre outro lápis.");
				return;
			}
			if (!Apontado)
			{
				Console.WriteLine("Aponte o lápis.");
				return;
			}
			Console.WriteLine(_texto);
			GastarPonta(10);
		}
	}
}
