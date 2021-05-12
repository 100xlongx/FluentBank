using System;
using Xunit;
using BankingService;
using FluentAssertions;
namespace BankingService.Tests
{
    public class Account_Deposit
    {
        [Theory]
        [InlineData(20)]
        [InlineData(25)]
        [InlineData(30)]
        public void Deposit_PositiveAmount_IncreasesBalance(int value)
        {
            // Arrange
            Account account = new Account("CX-3", "Monica", "Barns");
            // Act
            account.Deposit(value);
            // Assert
            account.Balance.Should().Be(value);
            account.Transactions[0].Should().Be($"Deposit: ${value}");
        }

        [Fact]
        public void Deposit_NegativeAmount_ThrowsException()
        {
            // Arrange
            Account account = new Account("CX-3", "Monica", "Barns");
            // Act
            Action action = () => account.Deposit(-10);
            // Assert
            action.Should().Throw<ApplicationException>()
            .WithMessage("Cannot deposit negative amounts");
            account.Transactions.Should().HaveCount(0);
        }
    }
}