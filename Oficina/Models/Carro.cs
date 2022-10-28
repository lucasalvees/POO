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
			set {
				if (VelocidadeAtual == 0)
					pneuTraseiroDireito = value;
				else
					Console.WriteLine("Não é possível trocar o pneu com o carro em movimento.");
			}
		}


		public Pneu PneuTraseiroEsquerdo
		{
			get { return pneuTraseiroEsquerdo; }
			set { 
				if (VelocidadeAtual == 0)
					pneuTraseiroEsquerdo = value;
                else
                    Console.WriteLine("Não é possível trocar o pneu com o carro em movimento.");
            }
		}


		public Pneu PneuDianteiroDireito
		{
			get { return pneuDianteiroDireito; }
			set { if (VelocidadeAtual == 0)
					pneuDianteiroDireito = value;
				else
					Console.WriteLine("Não é possível trocar o pneu com o carro em movimento.");
            }
		}


		public Pneu PneuDianteiroEsquerdo
		{
			get { return pneuDianteiroEsquerdo; }
			set { 
				 if (VelocidadeAtual == 0)
					pneuDianteiroEsquerdo = value;
                else
                    Console.WriteLine("Não é possível trocar o pneu com o carro em movimento.");
            }
		}


		public bool Ligado
		{
			get { return ligado; }
			set { ligado = value; }
		}

		public double Tanque
		{
			get { return tanque; }
			set { if (value == 0)
					LigarDesligar();
				tanque = value;
            }
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
			Tanque = 50;
			Ligado = false;
			PneuDianteiroEsquerdo = new Pneu(13, "Pirelli");
			PneuDianteiroDireito = new Pneu(13, "Pirelli");
            PneuTraseiroEsquerdo = new Pneu(13, "Pirelli");
            PneuTraseiroDireito = new Pneu(13, "Pirelli");
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

            if (Ligado)
            {
                PneuDianteiroDireito.Girar(_impulso);
                PneuDianteiroEsquerdo.Girar(_impulso);
                PneuTraseiroDireito.Girar(_impulso);
                PneuTraseiroEsquerdo.Girar(_impulso);
                VelocidadeAtual += _impulso;
            }
        }

        public void Frear(int _abatimento)
        {
			VelocidadeAtual -= _abatimento;
			if (VelocidadeAtual < 0)
				VelocidadeAtual = 0;

            PneuDianteiroDireito.Frear(_abatimento);
            PneuDianteiroEsquerdo.Frear(_abatimento);
            PneuTraseiroDireito.Frear(_abatimento);
            PneuTraseiroEsquerdo.Frear(_abatimento);
        }

        public void GastarCombustivel(double _fracao)
        {
			Tanque -= _fracao;
            if (Tanque < 0)
                Tanque = 0;
        }

		public void Exibir()
		{

            Console.WriteLine("Velocidade atual: " + velocidadeAtual);
			Console.WriteLine("Marca: " + marca);
			Console.WriteLine("Modelo: " + modelo);
			Console.WriteLine("Odomentro: " + odomentro);
			Console.WriteLine("Tanque: " + tanque);
			Console.WriteLine("Ligado: " + ligado);
			Console.WriteLine("Pneu dianteiro esquerdo: ");
            pneuDianteiroEsquerdo.Exibir();
            Console.WriteLine("pneuDianteiroDireito: ");
            pneuDianteiroDireito.Exibir();
            Console.WriteLine("pneuTraseiroEsquerdo: ");
            pneuTraseiroEsquerdo.Exibir();
            Console.WriteLine("pneuTraseiroDireito: ");
            pneuTraseiroEsquerdo.Exibir();
        }
    }
}
