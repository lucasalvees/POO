namespace Models
{
    public class Pneu
    {
		private string marca;
		private int tamanhoAro;
		private int psi;
		private int rotacao;
		private bool furado;
		private bool estourado;
		private double percetualBorracha;

		public string Marca
		{
			get { return marca; }
			set { marca = value; }
		}

		public int TamanhoAro
		{
			get { return tamanhoAro; }
			set { tamanhoAro = value; }
		}

		public bool Furado
		{
			get { return furado; }
			set { furado = value; }
		}

		public bool Estourado
		{
			get { return estourado; }
			set { estourado = value; }
		}

		public int Psi
		{
			get { return psi; }
			set { psi = value; }
		}

		public double PercentualBorracha
		{
			get { return percetualBorracha; }
			set { percetualBorracha = value; }
		}

		public int Rotacao
		{
			get { return rotacao; }
			set { rotacao = value; }
		}


		public Pneu(int _tamanhoAro, string _marca)
		{
			TamanhoAro = _tamanhoAro;
			Marca = _marca;
			Furado = false;
			Psi = 32;
			Estourado = false;
			PercentualBorracha = 100;
			Rotacao = 0;
		}

		public void Girar(int _rotacao)
		{
			if (Furado || Estourado)
				return;

            Rotacao += _rotacao;
			GastarBorracha(_rotacao / 100.0);
		}

		public void Frear(int _abatimento)
		{
			Rotacao -= _abatimento;
			GastarBorracha(_abatimento / 100.0);

			if (rotacao < 0)
				Rotacao = 0;
		}

		public void Furar()
		{
			Furado = true;
			Psi = 0;
		}

		public void Remendar()
		{
			Furado = false;
			Psi = 32;
		}

		private void GastarBorracha(double _quantidade)
		{
			PercentualBorracha -= _quantidade;
			if (PercentualBorracha <= 0)
				Estourar();
		}

		private void Estourar()
		{
			Estourado = true;
			Psi = 0;
			PercentualBorracha = 0;
			Rotacao = 0;
		}

		public void Exibir()
		{
			Console.WriteLine("Marca: " + marca);
            Console.WriteLine("Tamanho do Aro: " + tamanhoAro);
            Console.WriteLine("Psi: " + psi);
            Console.WriteLine("Furado: " + furado);
            Console.WriteLine("Estourado: " + estourado);
            Console.WriteLine("Percentual de borracha: " + percetualBorracha);
            Console.WriteLine("Rotação: " + rotacao);
        }
	}
}