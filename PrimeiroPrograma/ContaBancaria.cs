using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroPrograma
{
    public abstract class ContaBancaria
    {
        public Cliente Titular { get; set; }
        public int NumeroDaconta { get; set; }
        public double Saldo { get; set; }

        public ContaBancaria(Cliente Titular, int numeroDaconta, double saldo)
        {
            this.Titular = Titular;
            NumeroDaconta = numeroDaconta;
            Saldo = saldo;
        }
    }
}
