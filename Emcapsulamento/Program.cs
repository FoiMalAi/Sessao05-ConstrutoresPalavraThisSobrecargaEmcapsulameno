using Sessao05_ConstrutoresPalavraThisSobrecargaEmcapsulameno;

namespace Emcapsulamento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("TV", 500.00, 10);

            p.SetNome("TV 4K");

            Console.WriteLine(p.GetNome()); 

            //Forma manul de controlar o acesso aos atributos.
        }
    }
}
