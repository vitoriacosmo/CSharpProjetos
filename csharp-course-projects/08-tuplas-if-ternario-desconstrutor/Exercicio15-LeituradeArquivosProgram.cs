using Exercicio15.Models;
using System;

namespace Exercicio15
{
    public class Program
    {
        static void Main(string[] args)
        {
            LeituraArquivo arquivo = new LeituraArquivo();

            var (sucesso, linhasArquivo, quantidadeLinhas) = arquivo.LerArquivo(@"C:\Projetos\csharp-course-projects\csharp-course-projects\08-tuplas-if-ternario-desconstrutor\Exercicio15-LeituraArquivos\arquivoLeitura.txt");

            if (sucesso)
            {
                Console.WriteLine("Quantidade de linhas do arquivo: " + quantidadeLinhas);
                foreach (string linha in linhasArquivo)
                {
                    Console.WriteLine(linha);
                }
            }
            else
            {
                Console.WriteLine("Não foi possível ler o arquivo");
            }
        }
    }
}
