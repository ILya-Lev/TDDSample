using FluentAssertions;
using Xunit;

namespace TDD.MultiCurrencyMoney.Tests
{
    public class FrancTests
    {
        [Fact]
        public void Times_Scalar_ChangesAmount()
        {
            var five = Money.CreateFranc(5);
            five.Times(2).Equals(Money.CreateFranc(10)).Should().BeTrue();
            five.Times(3).Equals(Money.CreateFranc(15)).Should().BeTrue();
        }

        [Fact]
        public void Equals_DollarOfTheSameNote_False()
        {
            var franc = Money.CreateFranc(5);
            var dollar = Money.CreateDollar(5);
            franc.Equals(dollar).Should().BeFalse();
        }

    }
}