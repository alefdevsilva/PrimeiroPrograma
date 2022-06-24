﻿using System;
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
        public double TaxaCorrente { get; set; }

        public void RegrasContaCorrente()
        {
            throw new NotImplementedException();
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

        public override double Taxa()
        {
            for (int i = 1; i <= 12; i++)
            {
                TaxaCorrente = TaxaCorrente + 1;
            }
            return TaxaCorrente;
        }
    }
}
