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
        public string Nome;
        public double Preco;
        public int Quantidade;


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
            return Nome
            + ", $ "
            + Preco.ToString("F2")
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2");

        }
    }
}
