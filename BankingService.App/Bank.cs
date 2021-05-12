using System;
using System.Collections.Generic;
using BankingService;

namespace BankService
{
    public class Bank
    {
        private List<Account> _accountList;

        public List<Account> accountList
        {
            get { return _accountList; }
        }

        public Bank()
        {
            _accountList = new List<Account>();
        }
    }
}