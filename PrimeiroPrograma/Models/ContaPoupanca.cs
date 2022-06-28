using PrimeiroPrograma.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroPrograma.Models
{
    public class ContaPoupanca : ContaBancaria, IContaPoupanca
    {
        public ContaPoupanca(Cliente Titular, int numeroDaconta, double saldo) : base(Titular, numeroDaconta, saldo)
        {
        }
        public double TaxaPoupanca { get; set; }

        public void Depositar(double valorDposito)
        {
            if (valorDposito > 0)
            {
                Saldo += valorDposito;
                Console.WriteLine("Deposito realizado com sucesso! \n\nSaldo atual é de: " + Saldo);
            }
            else if (valorDposito == 0)
            {
                Console.WriteLine("Voce nao pode depositar o valor: " + valorDposito);
            }
        }

        public void Sacar(double valorDoSaque)
        {
            if (Saldo >= valorDoSaque)
            {
                Saldo = Saldo - valorDoSaque;
                Console.WriteLine("Saque realizado com sucesso! \n\nSaldo atual é de: " + Saldo);
            }
            else
            {
                Console.WriteLine("Saldo Insuficiente!\n\nSaldo atual é de: " + Saldo);
            }
        }

        public void Investimento()
        {
            double valorInvestido = 1000.0;
            for (int i = 1; i <= 12; i++)
            {
                valorInvestido = valorInvestido + 1; //* 1.01;
            }
            Console.WriteLine("Valor investido agora é " + valorInvestido);
        }

        public double consultaSaldo()
        {
            return Saldo;
        }
    }
}
