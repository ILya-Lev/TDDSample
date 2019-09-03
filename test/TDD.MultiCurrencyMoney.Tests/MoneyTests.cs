using FluentAssertions;
using Xunit;

namespace TDD.MultiCurrencyMoney.Tests
{
    public class MoneyTests
    {
        [Fact]
        public void FactoryMethods_ProduceInstancesOfExpectedCurrency()
        {
            Money.CreateDollar(1).Currency.Should().Be("USD");
            Money.CreateFranc(1).Currency.Should().Be("CHF");
        }

        [Fact]
        public void Equals_FrancOfTheSameNoteAsDollar_False()
        {
            var franc = Money.CreateFranc(5);
            var dollar = Money.CreateDollar(5);
            franc.Equals(dollar).Should().BeFalse();
        }
    }
}