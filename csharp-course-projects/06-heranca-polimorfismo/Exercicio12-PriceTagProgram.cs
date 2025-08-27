using Exercicio12.Entities;
using System;

namespace Exercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.WriteLine("Common, used or imported (c/u/i)? ");
                char caractere = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());


                if (caractere == 'c')
                {
                    list.Add(new Product(name, price));
                }

                else if (caractere == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    list.Add(new UsedProduct(name, price, date));

                }

                else
                {
                    Console.Write("Customs fee: ");
                    double fee = double.Parse(Console.ReadLine());
                    list.Add(new ImportedProduct(name, price, fee));

                }

                Console.WriteLine();
                Console.WriteLine("Price tags:");
                foreach (Product prod in list)
                {
                    Console.WriteLine(prod.PriceTag());
                }
            }
        }
    }
}
