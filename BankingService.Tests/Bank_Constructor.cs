using System;
using System.Collections.Generic;
using Xunit;
using BankingService;
using FluentAssertions;

namespace BankService.Tests {
    public class Bank_Constructor {
        [Fact]
        public void Should_InitializeANewBank_NotBeNull() {
            Bank bank = new Bank();

            bank.Should().NotBeNull();
        }

        [Fact]
        public void TestName() {
            Bank bank = new Bank();

            List<Account> accountList = bank.accountList;

            accountList.Should().NotBeNull();
        }
    }
}