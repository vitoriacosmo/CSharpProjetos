using Exercicio;
using System;

namespace Exercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o número de linhas e colunas da matriz: ");
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, n];

            for (int l = 0; l < n; l++)
            {
                string[] values = Console.ReadLine().Split(' ');
                for (int c = 0; c < n; c++)
                {
                    Console.Write($"Digite o valor para [{l},{c}]: ");
                    mat[l, c] = int.Parse(values[c]);
                }
            }

            Console.WriteLine("Diagonal principal: ");
            for (int l = 0; l < n; l++)
            {
                Console.Write(mat[i, i] + " ");
                Console.WriteLine();
            }

            int count = 0;
            for (int l = 0; l < n; l++)
            {
                for (int c = 0; c < n; c++)
                {
                    if (mat[l, c] < 0)
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine("Números negativos: " + count);
        }
    }
}