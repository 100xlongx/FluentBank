using System;
using FluentAssertions;
using Xunit;

namespace BankingService.Tests
{
    public class Account_Withdrawal
    {
        [Fact]
        public void WithdrawalFails_If_Balance_IsInsufficient()
        {
            //Given
            var account = new Account("CX-3", "Monica", "Barns");

            //When
            Action withdrawal = () => account.Withdrawal(50);

            //Then
            withdrawal.Should().Throw<ApplicationException>()
                .WithMessage("Cannot withdraw amount higher than balance.");
        }

        [Fact]
        public void WithdrawalFails_If_Amount_IsNegative()
        {
            //Given
            var account = new Account("CX-3", "Monica", "Barns");

            //When
            Action withdrawal = () => account.Withdrawal(-50);

            //Then
            withdrawal.Should().Throw<ApplicationException>()
                .WithMessage("Cannot withdraw negative amounts");
        }

        [Fact]
        public void WithdrawalPass_WhenBalance_IsHigherThanWithdrawalAmount()
        {
            //Given
            var account = new Account("CX-3", "Monica", "Barns");
            //When
            account.Deposit(50);
            account.Withdrawal(25);
            //Then
            account.Balance.Should().Be(25);
        }

        [Theory]
        [InlineData(25, 50)]
        [InlineData(30, 50)]
        [InlineData(40, 50)]
        public void Withdrawal_AddsToTransationList(int value, int depositAmount)
        {
            //given
            var account = new Account("CX-3", "Monica", "Barns");
            //when
            account.Deposit(depositAmount);
            account.Withdrawal(value);
            //then
            account.Transactions[1].Should().Be($"Withdrawal: ${value}");
        }
    }
}