using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ExercicioDeFixacao
{
    internal class ContaBancaria
    {
        public int Numero {get; private set;}
        public string Nome {get; set;}
        public double Saldo {get; private set;}

        public ContaBancaria(int numero, string nome)
        {
            Numero = numero;
            Nome = nome;
        }

        public ContaBancaria(int numero, string nome, double saldo):this(numero,nome)
        {
            Deposito(saldo);
        }

        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }

        public void Saque(double quantia)
        {
            Saldo -= quantia + 5.0;
        }

        public override string ToString()
        {
            return "Conta " + Numero
                + ", " + "Titular: "
                + Nome + ", Saldo: R$ "
                + Saldo.ToString("F2");                
        }
    }
}
