using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroPrograma
{
    public interface IContaCorrente
    {
        public void Sacar(double valorDoSaque);
        public void Depositar(double valorDposito);
        public double consultaSaldo();
    }
}
