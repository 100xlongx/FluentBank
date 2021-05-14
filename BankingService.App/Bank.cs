using System.Collections.Generic;
using BankingService;

namespace BankService
{
    public class Bank
    {
        public Bank()
        {
            AccountList = new List<Account>();
        }

        public List<Account> AccountList { get; }

        public void AddAccount(Account account2)
        {
            AccountList.Add(account2);
        }
    }
}