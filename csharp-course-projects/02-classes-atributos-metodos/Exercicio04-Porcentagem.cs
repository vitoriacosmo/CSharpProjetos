using PrimeiroProjeto;
using System;
using System.Globalization;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            Dados d = new Dados();

            Console.WriteLine("Insira os dados do funcionário: ");
            Console.Write("Nome: ");
            d.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            d.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            d.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("Funcionário: " + d.Nome + ", Salário Liquído $" + d.SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine();
            Console.Write("Digite a porcentagem para aumentar o salário: ");
            d.Porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            d.AumentarSalario();

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: ");
            Console.WriteLine("Nome: " + d.Nome + ", Salário: " + d.SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}