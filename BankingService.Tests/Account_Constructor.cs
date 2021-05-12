using System;
using Xunit;
using BankingService;
using FluentAssertions;

namespace BankingService.Tests
{
    public class Account_Constructor {
        [Fact]
        public void Should_InitializeBalanceAs0()
        {
            // Arrange
            // Act
            Account account = new Account("CX-3", "Monica", "Barns");
            // Assert
            account.Balance.Should().Be(0);
        }
        [Fact]
        public void Should_InitializeID_WithFirstParameter()
        {
            // Arrange
            // Act
            Account account = new Account("CX-3", "Monica", "Barns");
            // Assert
            account.Id.Should().Be("CX-3");
        }
        [Fact]
        public void Should_InitializeOwner_FirstAndLastNames_WithSecondAndThirdParameter()
        {
            // Arrange
            // Act
            Account account = new Account("CX-3", "Monica", "Barns");
            // Assert
            account.Owner.ToString().Should().Be("Monica Barns");
        }
    }
}