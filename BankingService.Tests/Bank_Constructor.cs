using System.Collections.Generic;
using BankingService;
using FluentAssertions;
using Xunit;

namespace BankService.Tests
{
    public class Bank_Constructor
    {
        [Fact]
        public void Should_InitializeANewBank_NotBeNull()
        {
            var bank = new Bank();

            bank.Should().NotBeNull();
        }

        [Fact]
        public void ShouldDeclareAccountList()
        {
            var bank = new Bank();

            List<Account> accountList = bank.AccountList;

            accountList.Should().NotBeNull();
        }

        [Fact]
        public void BankIsEmptyAtInit()
        {
            //Given
            var bank = new Bank();

            //When

            //Then
            bank.AccountList.Count.Should().Be(0);
        }

        [Fact]
        public void BankContainsOneAccount()
        {
            //Given
            var bank = new Bank();
            var account = new Account("1", "Pickle", "Rick");

            //When

            bank.AddAccount(account);

            //Then

            bank.AccountList.Should().Contain(account);
            bank.AccountList.Count.Should().Be(1);
        }

        [Fact]
        public void BankHoldsManyAccounts()
        {
            //Given
            var bank = new Bank();
            var account = new Account("1", "Pickle", "Rick");
            var account2 = new Account("2", "Minecraft", "Steve");

            //When

            bank.AddAccount(account);
            bank.AddAccount(account2);

            //Then

            bank.AccountList.Should().Contain(account);
            bank.AccountList.Should().Contain(account2);
            bank.AccountList.Count.Should().Be(2);
        }
    }
}