using FluentAssertions;
using Xunit;

namespace TDD.MultiCurrencyMoney.Tests
{
    public class DollarTests
    {
        [Fact]
        public void Times_Scalar_ChangesAmount()
        {
            var five = Money.Dollar(5);
            five.Times(2).Equals(Money.Dollar(10)).Should().BeTrue();
            five.Times(3).Equals(Money.Dollar(15)).Should().BeTrue();
        }

        [Fact]
        public void Equals_AnotherInstanceOfTheSameValue_True()
        {
            var five = Money.Dollar(5);
            var anotherFive = Money.Dollar(5);

            five.Equals(anotherFive).Should().BeTrue();
        }

        [Fact]
        public void Equals_AnotherInstanceOfDifferentValue_False()
        {
            var five = Money.Dollar(5);
            var six = Money.Dollar(6);

            five.Equals(six).Should().BeFalse();
        }

        [Fact]
        public void Equals_TheSameInstance_True()
        {
            var five = Money.Dollar(5);

            five.Equals(five).Should().BeTrue();
        }

        [Fact]
        public void Equals_ArbitraryObject_False()
        {
            var five = Money.Dollar(5);

            five.Equals(new object()).Should().BeFalse();
        }
    }
}
