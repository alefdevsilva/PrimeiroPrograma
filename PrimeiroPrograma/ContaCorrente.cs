using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroPrograma
{
    public class ContaCorrente : ContaBancaria, IContaCorrente
    {
        public ContaCorrente(Cliente Titular, int numeroDaconta, double saldo) : base(Titular, numeroDaconta, saldo)
        {
        }

        public double consultaSaldo()
        {
            return this.Saldo;
        }

        public void Depositar(double valorDposito)
        {
            if (valorDposito > 0)
            {
                this.Saldo += valorDposito;
                Console.WriteLine("Deposito realizado com sucesso! \n\nSaldo atual é de: " + this.Saldo);
            }
            else
            {
                Console.WriteLine("Voce nao pode depositar o valor: " + valorDposito);
            }
        }

        public void Sacar(double valorDeSaque)
        {
            
            if (this.Saldo >= valorDeSaque)
            {
                this.Saldo = this.Saldo - valorDeSaque;
                Console.WriteLine("Saque realizado com sucesso! \n\nSaldo atual é de: " + this.Saldo);
            }
            else
            {
                Console.WriteLine("Saldo Insuficiente!\n\nSaldo atual é de: " + this.Saldo);
            }
        }
    }
}
