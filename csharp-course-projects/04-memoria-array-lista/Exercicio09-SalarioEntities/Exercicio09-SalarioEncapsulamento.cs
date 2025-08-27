using System;
using System.Globalization;

namespace Exercicio09
{
    class Dados
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public void IncreaseSalary(double percentage)
        {
            Salary += Salary * percentage / 100.0;
        }
        public override string ToString()
        {
            return Id + ", " + Name + ", " + Salary;
        }
    }
}