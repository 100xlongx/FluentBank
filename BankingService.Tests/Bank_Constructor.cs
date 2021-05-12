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
        public void ShouldDeclareAccountList() {
            Bank bank = new Bank();

            List<Account> accountList = bank.accountList;

            accountList.Should().NotBeNull();
        }

        [Fact]
        public void BankIsEmptyAtInit()
        {
            //Given
            Bank bank = new Bank();
            
            //When
            
            //Then
            bank.accountList.Count.Should().Be(0);
        }

        [Fact]
        public void BankContainsOneAccount()
        {
            //Given
            Bank bank = new Bank();
            Account account = new Account("1", "Pickle", "Rick");

            //When

            bank.addAccount(account);
            
            //Then

            bank.accountList.Should().Contain(account);
            bank.accountList.Count.Should().Be(1);

        }

        [Fact]
        public void BankHoldsManyAccounts()
        {
            //Given
            Bank bank = new Bank();
            Account account = new Account("1", "Pickle", "Rick");
            Account account2 = new Account("2", "Minecraft", "Steve");
            
            //When

            bank.addAccount(account);
            bank.addAccount(account2);
            
            //Then
            
            bank.accountList.Should().Contain(account);
            bank.accountList.Should().Contain(account2);
            bank.accountList.Count.Should().Be(2);
        }
    }
}