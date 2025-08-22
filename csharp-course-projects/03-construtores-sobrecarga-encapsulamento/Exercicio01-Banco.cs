using Exercicio;
using System;
using System.Globalization;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o número da conta: ");
            Console.Write("Conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o nome do titular da conta: ");
            Console.Write("Nome: ");
            string titular = Console.ReadLine();
            Console.WriteLine("Haverá um depósito inicial? (S/N)");
            string resposta = Console.ReadLine();

            Dados d;

            if (resposta.ToUpper() == "S")
            {
                Console.WriteLine("Insira o valor do depósito incial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                d = new Dados(numero, titular, depositoInicial);
            }

            else
            {
                d = new Dados(numero, titular);
            }

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + d);

            Console.WriteLine();
            Console.WriteLine("Digite o valor que deseja depositar: ");
            double valor = double.Parse(Console.ReadLine());
            d.Depositar(valor);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + d);

            Console.WriteLine();
            Console.WriteLine("Digite o valor que deseja sacar: ");
            valor = double.Parse(Console.ReadLine());
            d.Sacar(valor);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + d);

        }
    }
}
