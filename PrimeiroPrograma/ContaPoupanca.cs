using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroPrograma
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
                this.Saldo += valorDposito;
                Console.WriteLine("Deposito realizado com sucesso! \n\nSaldo atual é de: " + this.Saldo);
            }
            else if (valorDposito == 0)
            {
                Console.WriteLine("Voce nao pode depositar o valor: " + valorDposito);
            }
        }

        public string RegraPoupanca()
        {
            throw new NotImplementedException();
        }

        public void Sacar(double valorDoSaque)
        {
            if (this.Saldo >= valorDoSaque)
            {
                this.Saldo = this.Saldo - valorDoSaque;
                Console.WriteLine("Saque realizado com sucesso! \n\nSaldo atual é de: " + this.Saldo);
            }
            else
            {
                Console.WriteLine("Saldo Insuficiente!\n\nSaldo atual é de: " + this.Saldo);
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

        public override double Taxa()
        {
            throw new NotImplementedException();
        }

        public double consultaSaldo()
        {
            return this.Saldo;
        }
    }
}
