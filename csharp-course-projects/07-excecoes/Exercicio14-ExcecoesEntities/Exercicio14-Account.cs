using System;
using System.Globalization;

namespace Exercicio14.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }
        public double Amount { get; set; }

        public Account()
        {
        }

        public Account(int number, string holder, double balance, double withdrawList)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawList;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (amount > WithdrawLimit)
            {
                throw new Exception("The amount exceeds withdraw limit");
            }
            if (amount > Balance)
            {
                throw new Exception("Not enough balance");
            }

            Balance -= amount;
        }
    }
}
