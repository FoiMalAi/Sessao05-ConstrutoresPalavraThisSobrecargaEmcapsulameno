namespace ExercicioDeFixacao02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaBnancaria conta;

            Console.Write("Entre o número da conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Entre o titular da conta: ");
            string nome = (Console.ReadLine());

            Console.Write("Haverá depósito inicial (s/n)? ");
            char resposta = char.Parse(Console.ReadLine());
            if (resposta == 'S' || resposta == 's')
            {
                Console.Write("Entre um valor para depósito: ");
                double depositoInicial = double.Parse(Console.ReadLine());
                conta = new ContaBnancaria(numero, nome, depositoInicial);
            }
            else
            {
                conta = new ContaBnancaria(numero, nome);
            }

            Console.WriteLine();

            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(conta);

            Console.WriteLine();

            Console.Write("Entre um valor para depósito: ");
            double quantia = double.Parse(Console.ReadLine());
            conta.Deposito(quantia);
            Console.WriteLine(conta);

            Console.Write("Entre um valor para saque: ");
            quantia = double.Parse(Console.ReadLine());
            conta.Saque(quantia);
            Console.WriteLine(conta);
        }
    }
}
