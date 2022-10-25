namespace Models
{
    public class Caneta
    {
        private string cor;
        private string marca;
        private string material;
        private string tipoPonta;
        private double tamanho;
        private double peso;
        private double ponta;
        private int percentualCarga;
        private bool tampada;
        private bool estourada;
        private bool caida;

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

        public int PercentualCarga
        {
            get { return percentualCarga; }
            set { percentualCarga = value; }
        }

        public double Tamanho
        {
            get { return tamanho; }
            set { tamanho = value; }
        }

        public double Peso
        {
            get { return peso; }
            set { peso = value; }
        }
        
        public bool Tampada
        {
            get { return tampada; }
            set { tampada = value; }
        }
        
        public string Material
        {
            get { return material; }
            set { material = value; }
        }

        public double Ponta
        {
            get { return ponta; }
            set { ponta = value; }
        }
        
        public string TipoPonta
        {
            get { return tipoPonta; }
            set { tipoPonta = value; }
        }
        
        public bool Caida
        {
            get { return caida; }
            set { caida = value; }
        }
        
        public bool Estourada
        {
            get { return estourada; }
            set { estourada = value; }
        }

        public Caneta(string _cor, string _marca, string _material)
        {
            Cor = _cor;
            Marca = _marca;
            Material = _material;
            PercentualCarga = 100;
        }

        public void Tampar()
        {
            Tampada = true;
        }
        public void Destampar()
        {
            Tampada = false;
        }
        public void Escrever(string _texto)
        {
            if (Tampada)
            {
                Console.WriteLine("A caneta está tampada.");
                return;
            }
            if (Caida)
            {
                Console.WriteLine("A caneta está no chão");
                return;
            }
            if (Estourada)
            {
                Console.WriteLine("A caneta está estourada.");
                return;
            }
            Console.WriteLine(_texto);
            GastaTinta();
        }

        private void GastaTinta()
        {
            PercentualCarga -= 10;
        }

        public void Exibir()
        {
            Console.WriteLine("Cor: " + Cor);
            Console.WriteLine("Marca: " + Marca);
            Console.WriteLine("Material: " + Material);
            Console.WriteLine("Percentual de Carga: " + PercentualCarga);
            Console.WriteLine("Tampada: " + Tampada);
        }
    }
}