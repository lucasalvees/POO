namespace Models
{
    public class Apontador
    {
		private string cor;
		private string marca;
		private string material;
		private int deposito;
		private bool depositoCheio;

		public string Cor
		{
			get { return cor; }
			set { cor = value; }
		}
		public string Marca
		{
			get { return marca; }
			set { marca = value; }
		}
		public string Material
		{
			get { return material; }
			set { material = value; }
		}

		public int Deposito
		{
			get { return deposito; }
			set { deposito = value; }
		}
        public bool DepositoCheio
        {
            get { return depositoCheio; }
            set { depositoCheio = value; }
        }

        public Apontador(string _cor, string _marca, string _material)
		{
			Cor = _cor;
			Marca = _marca;
			Material = _material;
			Deposito = 0;
		}

		public void Esvaziar()
        {
            Console.WriteLine("Depósito limpo.");
            Deposito = 0;
            depositoCheio = false;
        }

        public void Apontar()
        {
			if (Deposito == 100)
                depositoCheio = true;

			if (depositoCheio)
			{
                Console.WriteLine("Depósito cheio, esvazie.");
				return;
            }
			EncherDeposito();	
        }

		private void EncherDeposito()
		{
            Deposito += 10;
        }

		public void Exibir()
		{
			Console.WriteLine("Marca: " + Marca);
            Console.WriteLine("Cor: " + Cor);
            Console.WriteLine("Material: " + Material);
            Console.WriteLine("Depósito Cheio: " + DepositoCheio);
            Console.WriteLine("Percentual do Depósito: " + Deposito);
        }
    }
}
