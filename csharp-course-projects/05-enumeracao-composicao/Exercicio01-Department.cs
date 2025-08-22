
using System;
using Course.Entities;

namespace Course.Entities
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