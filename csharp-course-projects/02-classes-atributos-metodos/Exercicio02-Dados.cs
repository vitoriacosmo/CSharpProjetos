using System;
using PrimeiroProjeto;

namespace questoes
{
    class Program
    {
        static void Main(string[] args)
        {
            Dados x, y;
            x = new Dados();
            y = new Dados();

            Console.WriteLine("Insira o nome e salário do primeiro funcionário: ");
            x.Nome = (Console.ReadLine());
            x.Salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira o nome e salário do segundo funcionário: ");
            y.Nome = (Console.ReadLine());
            y.Salario = double.Parse(Console.ReadLine());

            double media = (x.Salario + y.Salario) / 2;

            Console.WriteLine("Salário médio = " + media);

        }
    }
}