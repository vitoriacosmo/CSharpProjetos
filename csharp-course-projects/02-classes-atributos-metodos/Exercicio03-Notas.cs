using PrimeiroProjeto;
using System;
using System.Globalization;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            Notas n = new Notas();

            Console.WriteLine("Insira os dados do aluno: ");
            Console.Write("Nome: ");
            n.Nome = Console.ReadLine();
            Console.Write("Nota Um: ");
            n.NotaUm = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Nota Dois: ");
            n.NotaDois = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Nota Três: ");
            n.NotaTres = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("Nota final: " + n.Media().ToString("F2", CultureInfo.InvariantCulture));

            if (n.Media() >= 60.00)
            {
                Console.WriteLine("Aprovado");
            }

            else
            {
                double faltantes = 60.00 - n.Media();
                Console.WriteLine("Faltam " + faltantes + " pontos");
                Console.WriteLine("Reprovado");
            }
        }
    }
}