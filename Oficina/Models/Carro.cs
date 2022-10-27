namespace Models
{
    public class Carro
    {
		private int velocidadeAtual;
		private string marca;
		private string modelo;
		private int odomentro;
		private double tanque;
		private bool ligado;
		private Pneu pneuDianteiroEsquerdo;
		private Pneu pneuDianteiroDireito;
		private Pneu pneuTraseiroEsquerdo;
		private Pneu pneuTraseiroDireito;

		public Pneu PneuTraseiroDireito
		{
			get { return pneuTraseiroDireito; }
			set { pneuTraseiroDireito = value; }
		}


		public Pneu PneuTraseiroEsquerdo
		{
			get { return pneuTraseiroEsquerdo; }
			set { pneuTraseiroEsquerdo = value; }
		}


		public Pneu PneuDianteiroDireito
		{
			get { return pneuDianteiroDireito; }
			set { pneuDianteiroDireito = value; }
		}


		public Pneu PneuDianteiroEsquerdo
		{
			get { return pneuDianteiroEsquerdo; }
			set { pneuDianteiroEsquerdo = value; }
		}


		public bool Ligado
		{
			get { return ligado; }
			set { ligado = value; }
		}

		public double Tanque
		{
			get { return tanque; }
			set { tanque = value; }
		}


		public int Odomentro
		{
			get { return odomentro; }
			set { odomentro = value; }
		}

		public string Modelo
		{
			get { return modelo; }
			set { modelo = value; }
		}

		public string Marca
		{
			get { return marca; }
			set { marca = value; }
		}

		public int VelocidadeAtual
		{
			get { return velocidadeAtual; }
			set { velocidadeAtual = value; }
		}

		public Carro(string marca, string modelo)
		{
			VelocidadeAtual = velocidadeAtual;
			Marca = marca;
			Modelo = modelo;
			this.odomentro = 0;
			Tanque = 5;
			Ligado = false;
			PneuDianteiroEsquerdo = new Pneu(14, "Pirelli");
			PneuDianteiroDireito = new Pneu(14, "Pirelli");
            PneuTraseiroEsquerdo = new Pneu(14, "Pirelli");
            PneuTraseiroDireito = new Pneu(14, "Pirelli");
        }

		public void LigarDesligar()
		{
			Ligado = !Ligado;
			if (!Ligado)
			{
				Frear(VelocidadeAtual);
			}
		}

		public void Acelerar(int _impulso)
		{
			if (!Ligado)
				return;

			if (tanque == 0)
				LigarDesligar();

			GastarCombustivel(_impulso / 100.0);
			PneuDianteiroDireito.Girar(_impulso);
			PneuDianteiroEsquerdo.Girar(_impulso);
			PneuTraseiroDireito.Girar(_impulso);
			VelocidadeAtual += _impulso;
		}

        public void Frear(int _abatimento)
        {
			VelocidadeAtual -= _abatimento;
			if (VelocidadeAtual < 0)
				VelocidadeAtual = 0;
        }

        public void GastarCombustivel(double _fracao)
        {
			Tanque -= _fracao;
        }

		public void Exibir()
		{

            Console.WriteLine("Velocidade atual: " + velocidadeAtual);
			Console.WriteLine("Marca: " + marca);
			Console.WriteLine("Modelo: " + modelo);
			Console.WriteLine("Odomentro: " + odomentro);
			Console.WriteLine("Tanque: " + tanque);
			Console.WriteLine("Ligado: " + ligado);
			Console.WriteLine("Pneu dianteiro esquerdo: " + pneuDianteiroEsquerdo);
			Console.WriteLine("pneuDianteiroDireito: " + pneuDianteiroDireito);
			Console.WriteLine("pneuTraseiroEsquerdo: " + pneuTraseiroEsquerdo);
			Console.WriteLine("pneuTraseiroDireito: " + pneuTraseiroDireito);
		 }
    }
}
