using FluentAssertions;
using Xunit;

namespace TDD.MultiCurrencyMoney.Tests
{
    public class FrancTests
    {
        [Fact]
        public void Times_Scalar_ChangesAmount()
        {
            var five = Money.Franc(5);
            five.Times(2).Equals(Money.Franc(10)).Should().BeTrue();
            five.Times(3).Equals(Money.Franc(15)).Should().BeTrue();
        }

        [Fact]
        public void Equals_DollarOfTheSameNote_False()
        {
            var franc = Money.Franc(5);
            var dollar = Money.Dollar(5);
            franc.Equals(dollar).Should().BeFalse();
        }

    }
}