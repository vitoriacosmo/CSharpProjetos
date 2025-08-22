using System;
using System.Globalization;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Entre com seu nome: ");
        string nome = Console.ReadLine();

        Console.WriteLine("Quantos quartos tem na sua casa? ");
        string quartos = Console.ReadLine();

        Console.WriteLine("Entre com o preço de um produto: ");
        string preco = Console.ReadLine();

        Console.WriteLine("Entre com seu último nome, idade e altura (na mesma linha): ");
        string[] v = Console.ReadLine().Split(' ');

        string ultimonome = v[0];
        int idade = int.Parse(v[1]);
        double altura = double.Parse(v[2], CultureInfo.InvariantCulture);

        Console.WriteLine(nome);
        Console.WriteLine(quartos);
        Console.WriteLine(preco);
        Console.WriteLine(ultimonome);
        Console.WriteLine(idade);
        Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
    }
}
