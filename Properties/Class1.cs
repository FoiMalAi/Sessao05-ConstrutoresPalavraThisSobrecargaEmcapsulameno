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
        private string _nome;
        private double _preco;
        private int _quantidade;


        /* A criação do construtor deve ser feita sempre após
           as caracteristicas */

        public Produto() // Construtor padrao
        {
        }
        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;  // construtor com os 3 argumentos
            _preco = preco;
            _quantidade = quantidade;
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

        public double Preco
        {
            get { return _preco;}
        }

        public int Quantidade
        {
            get { return _quantidade; }
        }

        public double ValorTotalEmEstoque()
        {
            return _preco * _quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            _quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            _quantidade -= quantidade;
        }
        public override string ToString()
        {
            return _nome
            + ", $ "
            + _preco.ToString("F2")
            + ", "
            + _quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2");

        }
    }
}
