using System;
using System.Globalization;

namespace integracao {
    class Produto {
        private string _nome;
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }

        public Produto() {
        }       
        public Produto(string nome, double preco, int quantidade)  {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;

        }

        public string Nome {
            get {
                return _nome;
            }
            set {
                if (value != null && value.Length > 1) {
                    _nome = value;
                }
            }
        
        }
       

        public double ValorTotalEmEstoque() {
            return Preco * Quantidade;
        }

        public void AdicioneProdutos(int quantidade) {
            Quantidade = Quantidade + quantidade; //A operação Quantidade + quantidade pode ser trocada por -=

        }
        public void RemoverProdutos(int quantidade) {
            Quantidade = Quantidade - quantidade;

        }

        public override string ToString() {
            return Nome 
                + ", R$ " 
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                +", "
                + Quantidade 
                + "unidade, Total: R$ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
   
}
