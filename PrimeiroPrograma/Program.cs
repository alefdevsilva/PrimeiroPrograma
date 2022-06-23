using System;
using System.Globalization;
using PrimeiroPrograma;

namespace primeiroPrograma
{
    class Program
    {
        public static void Main(string[] args)
        {
            /*
            string Nome = "Alef Alessandro";
            Console.WriteLine(Nome);
            int numero1 = 1;
            int numeroInteiro2 = 10;
            Console.WriteLine(numero1);
            double numero2 = 2.2222;
            Console.WriteLine(numero2.ToString("F2", CultureInfo.InvariantCulture));
            bool condicao = true;
            Console.WriteLine(condicao);
            decimal numero3 = 3.45234M;
            Console.WriteLine(numero3);
            char sexo = 'M';
            Console.WriteLine(sexo);

            int resultado = numero1 + numeroInteiro2;
            Console.WriteLine(resultado);

            string NomeCompleto = Console.ReadLine();
            Console.WriteLine(NomeCompleto);
            //Console.ReadKey();

            int numeroInteiroTela = int.Parse(Console.ReadLine());
            Console.WriteLine("O numero digitado foi: " + numeroInteiroTela.ToString());
            
            

            string frase = Console.ReadLine();
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();
      

            Console.WriteLine("Você digitou: ");
            Console.WriteLine(frase);

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine();
            */

            //ESTRUTURAS DE CONTROLE

            //double valorSaque = 10.0;
            //Sacar();
            //Depositar();
            //Console.WriteLine("Digite a operacao que deseja executar: ");
            //char operacao = char.Parse(Console.ReadLine());
            //Calculadora(operacao);
            //ESTRUTURAS DE REPETIÇÃO

            //Investimento();

            Cliente cliente = new Cliente();
            cliente.Nome = "Alef";
            cliente.Cpf = "46565465450";
            cliente.Rg = "658745874";
            //cliente.Endereco.Rua = "Rua das Garças";
            //ContaBancaria contaBancaria = new ContaBancaria(cliente, 1234, 3000.00);
            //ContaBancaria contaBancaria = new ContaPoupanca(cliente, 1234, 3000.00);
            ContaPoupanca poupanca = new ContaPoupanca(cliente, 1234, 10.000);
            Console.WriteLine("Poupanca: " + poupanca.Titular.Nome);
            //Console.WriteLine(contaBancaria.Titular.Nome);

            //contaBancaria.Deposita(1000.00);

            ContaCorrente corrente = new ContaCorrente(cliente, 1234, 10.000);
            Console.WriteLine("Taxa da conta corrente R$ " + corrente.Taxa() + " reais por ano");

            corrente.RegrasContaCorrente();
         
        }
        static void Sacar()
        {
            double saldo = 100.0;
            Console.WriteLine("Digite o valor a ser sacado");
            double valorSaque = double.Parse(Console.ReadLine());
            if (saldo >= valorSaque)
            {
                saldo = saldo - valorSaque;
                Console.WriteLine("Saque realizado com sucesso! \n\nSaldo atual é de: " + saldo);
            }
            else
            {
                Console.WriteLine("Saldo Insuficiente!\n\nSaldo atual é de: " + saldo);
            }
        }
        static void Depositar()
        {
            double saldo = 0.0;
            Console.WriteLine("Digite o valor que deseja depositar");
            double valordeposito = double.Parse(Console.ReadLine());
            if (valordeposito > 0)
            {
                saldo = saldo + valordeposito;
                Console.WriteLine("Deposito realizado com sucesso! \n\nSaldo atual é de: " + saldo);
            }
            else if(valordeposito == 0)
            {
                Console.WriteLine("Voce nao pode depositar o valor: " + valordeposito);
            }
        }
        static void Calculadora(char operacao)
        {
            char continuar = 's';
            while (continuar == 's')
            {
                int resultado = 0;
                int numero1 = 0;
                int numero2 = 0;
                switch (operacao)
                {
                    case '+':
                        Console.WriteLine("Digite os numeros da operação");
                        numero1 = Convert.ToInt32(Console.ReadLine());
                        numero2 = Convert.ToInt32(Console.ReadLine());
                        resultado = numero1 + numero2;
                        Console.WriteLine("soma!\n\nO resultado é: " + resultado);
                        break;
                    case '-':
                        Console.WriteLine("Digite os numeros da operação");
                        numero1 = Convert.ToInt32(Console.ReadLine());
                        numero2 = Convert.ToInt32(Console.ReadLine());
                        resultado = numero1 - numero2;
                        Console.WriteLine("subtração!\n\nResultado da subtração: {0} por {1} é: {2}",numero1, numero2, resultado);
                        break;
                    case '*':
                        Console.WriteLine("Digite os numeros da operação");
                        numero1 = Convert.ToInt32(Console.ReadLine());
                        numero2 = Convert.ToInt32(Console.ReadLine());
                        resultado = numero1 * numero2;
                        Console.WriteLine($"multiplicação\n\nO resultado é: {resultado}");
                        break;
                    case '/':
                        Console.WriteLine("Digite os numeros da operação");
                        numero1 = Convert.ToInt32(Console.ReadLine());
                        numero2 = Convert.ToInt32(Console.ReadLine());
                        resultado = numero1 / numero2;
                        Console.WriteLine("divisão\n\nO resultado é: " + resultado);
                        break;
                    default: 
                        Console.WriteLine("Operacao nao permitida!\n\nUse as operações(+, -, *, /)");
                        break;
                }
                Console.WriteLine("Deseja fazer mais alguma operação? s/n?" );
                continuar = char.Parse(Console.ReadLine());
            }    
        }
        static void Investimento()
        {
            double valorInvestido = 1000.0;
            for (int i = 1; i <= 12; i++)
            {
                valorInvestido = valorInvestido + 1; //* 1.01;
            }
            Console.WriteLine("Valor investido agora é " + valorInvestido);
        }
    }
}