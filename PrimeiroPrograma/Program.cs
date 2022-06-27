using System;
using System.Globalization;
using PrimeiroPrograma;

namespace primeiroPrograma
{
    class Program
    {
        public static void Main(string[] args)
        {
            Cliente cliente = new Cliente();
            cliente.Nome = "Alef";
            cliente.Cpf = "46565465450";
            cliente.Rg = "658745874";
            
            //ContaPoupanca poupanca = new ContaPoupanca(cliente, 1234, 10000);
            
            
            ContaCorrente corrente = new ContaCorrente(cliente, 1234, 10000);

            Console.WriteLine("Poupanca: " + corrente.Titular.Nome);
            Console.WriteLine("Digite o valor a ser sacado");
            double valorSaque = double.Parse(Console.ReadLine());
            corrente.Sacar(valorSaque);
            corrente.consultaSaldo();
            Console.WriteLine("Digite o valor a ser depositado: ");
            double valorDeposito = double.Parse(Console.ReadLine());
            corrente.Depositar(valorDeposito);
            corrente.consultaSaldo();

        }
    }
}