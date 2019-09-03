using FluentAssertions;
using Xunit;

namespace TDD.MultiCurrencyMoney.Tests
{
    public class MoneyTests
    {
        [Fact]
        public void Currency_MatchExpectations_()
        {
            Money.CreateDollar(1).GetCurrency().Should().Be("USD");
            Money.CreateFranc(1).GetCurrency().Should().Be("CHF");
        }
    }
}