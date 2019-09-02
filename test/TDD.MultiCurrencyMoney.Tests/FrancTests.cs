using FluentAssertions;
using Xunit;

namespace TDD.MultiCurrencyMoney.Tests
{
    public class FrancTests
    {
        [Fact]
        public void Times_Scalar_ChangesAmount()
        {
            var five = new Franc(5);
            five.Times(2).Equals(new Franc(10)).Should().BeTrue();
            five.Times(3).Equals(new Franc(15)).Should().BeTrue();
        }

        [Fact]
        public void Equals_DollarOfTheSameNote_False()
        {
            var franc = new Franc(5);
            var dollar = new Dollar(5);
            franc.Equals(dollar).Should().BeFalse();
        }

    }
}