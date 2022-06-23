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

        public string RegraPoupanca()
        {
            throw new NotImplementedException();
        }

        public override double Taxa()
        {
            throw new NotImplementedException();
        }
    }
}
