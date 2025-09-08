﻿using System.Globalization;

namespace Exercicio16.Entities
{
    class Invoice
    {
        public double BasicPayment { get; set; }
        public double Tax { get; set; }

        public Invoice() 
        { 
        }

        public Invoice(double basicPayment, double tax)
        {
            BasicPayment = basicPayment;
            Tax = tax;
        }

        public double TotalPayment
        {
            get { return BasicPayment + Tax; }
        }

        public override string ToString()
        {
            return "INVOICE: " + "\nBASIC PAYMENT: " + BasicPayment.ToString("F2", CultureInfo.InvariantCulture) + "\nTAX: " + Tax.ToString("F2", CultureInfo.InvariantCulture) + "\nTOTAL PAYMENT: " + TotalPayment.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
