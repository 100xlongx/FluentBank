using System;
using System.Collections.Generic;

namespace BankingService
{
    public class Account
    {
        public Account(string id, string first, string last)
        {
            Balance = 0;
            Id = id;
            Owner = new User {First = first, Last = last};
            Transactions = new List<string>();
        }

        public decimal Balance { get; private set; }

        public List<string> Transactions { get; }

        public string Id { get; set; }
        public User Owner { get; set; }

        public void Deposit(decimal amount)
        {
            if (amount < 0) throw new ApplicationException("Cannot deposit negative amounts");
            Balance += amount;
            Transactions.Add($"Deposit: ${amount}");
        }

        public void Withdrawal(decimal amount)
        {
            if (amount > Balance) throw new ApplicationException("Cannot withdraw amount higher than balance.");

            if (amount < 0) throw new ApplicationException("Cannot withdraw negative amounts");

            Balance -= amount;
            Transactions.Add($"Withdrawal: ${amount}");
        }
    }
}