using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroPrograma.Models
{
    public class Cliente
    {
        public string Nome { get; set; } = string.Empty;
        public string Cpf { get; set; } = string.Empty;
        public string Rg { get; set; } = string.Empty;
        public Endereco Endereco { get; set; }

        public Cliente(string nome, string rg, string cpf, Endereco enredero)
        {
            this.Endereco = enredero;
            this.Nome = nome;
            this.Rg = rg;
            this.Cpf = cpf;
        }
    }
}
