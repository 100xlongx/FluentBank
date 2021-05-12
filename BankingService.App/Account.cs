using System;
using System.Collections.Generic;

namespace BankingService
{
    public class Account
    {
        private decimal _balance;
        private List<string> _transactions;
        public decimal Balance{
            get { return _balance; } 
        }
        public List<string> Transactions { 
            get { return _transactions; } 
        }
        public string Id { get; set; }
        public User Owner { get; set; }
        public Account(string id, string first, string last){
            _balance = 0;
            Id = id;
            Owner = new User{ First = first, Last = last };
            _transactions = new List<string>();
        }
        public void Deposit(decimal amount){
            if (amount < 0){
                throw new ApplicationException("Cannot deposit negative amounts");
            }
            _balance += amount;
            _transactions.Add($"Deposit: ${amount}");
        }

        public void Withdrawal(decimal amount) {
            if (amount > this.Balance) {
                throw new ApplicationException("Cannot withdraw amount higher than balance.");
            }
        }
    }
}