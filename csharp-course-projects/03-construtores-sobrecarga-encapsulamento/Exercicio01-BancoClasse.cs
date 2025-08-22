using System
using System.Globalization;

namespace Exercicio
{
    class Dados
    {
        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public Dados(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
        }

        public Dados(int numero, string titular, double saldo) : this(numero, titular)
        {
            Saldo = saldo;
        }

        public void Depositar(double valor)
        {
            Saldo += valor;
        }

        public void Sacar(double valor)
        {
            Saldo -= (valor + 5.0);
        }

        public override string ToString()
        {
            return "Conta: "
                + Numero
                + ", Titular: "
                + Titular
                + ", Saldo Atual: $"
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
