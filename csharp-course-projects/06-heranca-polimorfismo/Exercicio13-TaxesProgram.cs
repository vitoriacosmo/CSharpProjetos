using Exercicio.Entities;
using System;
using System.Globalization;

namespace Exercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> list = new List<TaxPayer>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or company (i/c)? ");
                char caractere = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double income = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


                if (caractere == 'c')
                {
                    Console.Write("Number of employees: ");
                    int employees = int.Parse(Console.ReadLine());
                    list.Add(new Company(name, income, employees));
                }

                else
                {
                    Console.Write("Health expenditures: ");
                    double expenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Individual(name, income, expenditures));

                }
            }

            double sum = 0.0;
            Console.WriteLine();
            Console.WriteLine("Taxes Paid:");
            foreach (TaxPayer taxespaid in list)
            {
                double tax = taxespaid.Tax();
                Console.WriteLine(taxespaid.Name + ": $ " + tax.ToString("F2", CultureInfo.InvariantCulture));
                sum += tax;
            }

            Console.WriteLine("Total Taxes: $" + sum.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
