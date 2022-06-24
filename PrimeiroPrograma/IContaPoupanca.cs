using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroPrograma
{
    public interface IContaPoupanca
    {
        public void Sacar(double valorDoSaque);
        public void Depositar(double valorDposito);
        public void Investimento();
        public double consultaSaldo();

    }
}
