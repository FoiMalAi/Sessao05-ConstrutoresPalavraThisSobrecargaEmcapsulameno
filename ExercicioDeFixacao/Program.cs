using System.Globalization;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ExercicioDeFixacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta; // foi declarada aqui, para entrar no escopo do IF

            Console.Write("Entre com o numero da conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Entre com o titular da conta: ");
            string nome = Console.ReadLine();

            Console.Write("Haverá saldo inicial (S/N): ");
            char resposta = char.Parse(Console.ReadLine());

            if (resposta == 's' || resposta == 's')
            {
                Console.Write("Entre com o valor do saldo inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine());
                conta = new ContaBancaria(numero, nome, depositoInicial);
            }
            else
            {
                conta = new ContaBancaria(numero, nome);
            }

            Console.WriteLine();

            Console.Write("Entre com um valor para o deposito: ");
            double quantia = double.Parse(Console.ReadLine());
            conta.Deposito(quantia);
            Console.WriteLine("Dados atualizados: ");
            Console.WriteLine(conta);

            Console.Write("Entre com o valor para saque: ");
            quantia = double.Parse(Console.ReadLine());
            conta.Saque(quantia);
            Console.WriteLine("Dados atualizados: ");
            Console.WriteLine(conta);
        }
    }
}
