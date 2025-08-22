using System;

namespace PrimeiroProjeto
{
    internal class Dados
    {
        public string Nome;
        public double Salario;
        public double Imposto;
        public double Porcentagem;

        public double SalarioLiquido()
        {
            return Salario - Imposto;
        }

        public void AumentarSalario()
        {
            Salario += Salario * Porcentagem / 100;
        }

    }
}