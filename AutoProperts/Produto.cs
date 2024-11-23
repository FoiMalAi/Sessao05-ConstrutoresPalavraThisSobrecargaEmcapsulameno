using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sessao05_ConstrutoresPalavraThisSobrecargaEmcapsulameno
{
    internal class Produto
    {
        private string _nome; // quando o propert possui logica, se usa o manual. 
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }


        /* A criação do construtor deve ser feita sempre após
           as caracteristicas */

        public Produto() // Construtor padrao
        {
        }
        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;  // construtor com os 3 argumentos
            Preco = preco;
            Quantidade = quantidade;
        }

        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }
        public override string ToString()
        {
            return _nome
            + ", $ "
            + Preco.ToString("F2")
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2");

        }
    }
}
