
using System;
using Course.Entities;

namespace Exercicio11.Entities
{
    internal class Department
    {
        public string Name { get; set; }

        public Department()
        {

        }

        public Department(string name)
        {
            Name = name;
        }
    }
}