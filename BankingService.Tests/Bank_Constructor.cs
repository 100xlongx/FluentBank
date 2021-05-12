using System;
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
    }
}