using System;
using System.Globalization;
using PrimeiroPrograma.Models;

namespace primeiroPrograma
{
    class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Cliente cliente;
                Endereco endereco;
                Console.WriteLine("Escolha o tipo de conta:\n1 - Conta Corrente\n2 - Conta Poupança\n3 - para sair");
                int opcao = int.Parse(Console.ReadLine());
                if (opcao == 3)
                {
                    break;
                }
                else if (opcao == 1)
                {
                    Console.WriteLine("digite seu nome:");
                    string nome = Console.ReadLine();
                    Console.WriteLine("digite seu RG:");
                    string rg = Console.ReadLine();
                    Console.WriteLine("digite seu CPF:");
                    string cpf = Console.ReadLine();
                    Console.WriteLine("digite o seu endereço(rua):");
                    string rua = Console.ReadLine();
                    Console.WriteLine("digite o número:");
                    string numero = Console.ReadLine();
                    Console.WriteLine("digite o CEP:");
                    string cep = Console.ReadLine();
                    Console.WriteLine("digite o nome do seu pais:");
                    string pais = Console.ReadLine();
                    Console.WriteLine("digite o nome do seu bairro:");
                    string bairro = Console.ReadLine();
                    Console.WriteLine("digite o nome da sua cidade:");
                    string cidade = Console.ReadLine();
                    endereco = new Endereco(rua, numero, cep, bairro, cidade, pais);
                    cliente = new Cliente(nome, rg, cpf, endereco);
                    Console.WriteLine("digite seu saldo inicial:");
                    double saldo = double.Parse(Console.ReadLine());
                    ContaCorrente corrente = new ContaCorrente(cliente, 1234, saldo);
                    Console.WriteLine("sua conta foi criada com sucesso!");
                    while (true)
                    {
                        Console.WriteLine("Deseja fazer alguma operação?\n1 - sacar\n2-depositar\n3 - ver saldo\n4- sair");
                        int escolha = int.Parse(Console.ReadLine());
                        if (escolha == 4)
                        {
                            break;
                        }
                        else if (escolha == 1)
                        {
                            Console.WriteLine("Digite o valor a ser sacado");
                            double valor = double.Parse(Console.ReadLine());
                            Console.WriteLine("a taxa de saque é R$1,00, deseja continua:\n1 - sim\n2 - não");
                            int continua = int.Parse(Console.ReadLine());
                            if (continua == 1)
                            {
                                corrente.Sacar(valor);
                            }
                            else
                            {
                                continue;
                            }   
                        }
                        else if (escolha == 2)
                        {
                            Console.WriteLine("Digite o valor a ser depositado");
                            double valor = double.Parse(Console.ReadLine());
                            corrente.Depositar(valor);
                        }
                        else if (escolha == 3)
                        {
                            Console.WriteLine(corrente.consultaSaldo());
                        }
                        else
                        {
                            Console.WriteLine("Escolha uma operação valida");
                            Console.Clear();
                        }
                    }
                }
                else if (opcao == 2)
                {
                    Console.WriteLine("digite seu nome:");
                    string nome = Console.ReadLine();
                    Console.WriteLine("digite seu RG:");
                    string rg = Console.ReadLine();
                    Console.WriteLine("digite seu CPF:");
                    string cpf = Console.ReadLine();
                    Console.WriteLine("digite o seu endereço(rua):");
                    string rua = Console.ReadLine();
                    Console.WriteLine("digite o número:");
                    string numero = Console.ReadLine();
                    Console.WriteLine("digite o CEP:");
                    string cep = Console.ReadLine();
                    Console.WriteLine("digite o nome do seu pais:");
                    string pais = Console.ReadLine();
                    Console.WriteLine("digite o nome do seu bairro:");
                    string bairro = Console.ReadLine();
                    Console.WriteLine("digite o nome da sua cidade:");
                    string cidade = Console.ReadLine();
                    endereco = new Endereco(rua, numero, cep, bairro, cidade, pais);
                    cliente = new Cliente(nome, rg, cpf, endereco);
                    Console.WriteLine("digite seu saldo inicial:");
                    double saldo = double.Parse(Console.ReadLine());
                    ContaPoupanca poupanca = new ContaPoupanca(cliente, 1234, saldo);
                    Console.WriteLine("sua conta foi criada com sucesso!");
                    while (true)
                    {
                        Console.WriteLine("Deseja fazer alguma operação?\n1 - sacar\n2-depositar\n3 - ver saldo\n4- sair");
                        int escolha = int.Parse(Console.ReadLine());
                        if (escolha == 4)
                        {
                            break;
                        }
                        else if (escolha == 1)
                        {
                            Console.WriteLine("Digite o valor a ser sacado");
                            double valor = double.Parse(Console.ReadLine());
                            poupanca.Sacar(valor);
                        }
                        else if (escolha == 2)
                        {
                            Console.WriteLine("Digite o valor a ser depositado");
                            double valor = double.Parse(Console.ReadLine());
                            poupanca.Depositar(valor);
                        }
                        else if (escolha == 3)
                        {
                            Console.WriteLine(poupanca.consultaSaldo());
                        }
                        else
                        {
                            Console.WriteLine("Escolha uma operação valida");
                            Console.Clear();
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Escolha uma operação valida");
                    Console.Clear();
                    continue;
                }
            }
        }
    }
}