using System;
using System.Collections.Generic;
using System.Globalization;

namespace Exercicio12.Entities
{
    class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct()
        {
        }

        public UsedProduct(string name, double price, DateTime manufactureDate) : base(name, price)
        {
            ManufactureDate = manufactureDate;
        }

        public override string PriceTag()
        {
            return Name
                + " (used) $"
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                + " ManufactureDate: "
                + ManufactureDate.ToString("dd/MM/yyyy")
                + ")";
        }
    }
}
