using FluentAssertions;
using Xunit;

namespace TDD.MultiCurrencyMoney.Tests
{
    public class DollarTests
    {
        private readonly Money _five = Money.CreateDollar(5);

        [Fact]
        public void Times_Scalar_ChangesAmount()
        {
            _five.Times(2).Equals(Money.CreateDollar(10)).Should().BeTrue();
            _five.Times(3).Equals(Money.CreateDollar(15)).Should().BeTrue();
        }

        [Fact]
        public void Equals_AnotherInstanceOfDifferentValue_False()
        {
            var six = Money.CreateDollar(6);

            _five.Equals(six).Should().BeFalse();
        }

        [Fact]
        public void Equals_TheSameInstance_True() => _five.Equals(_five).Should().BeTrue();

        [Fact]
        public void Equals_ArbitraryObject_False() => _five.Equals(new object()).Should().BeFalse();

        [Fact]
        public void Equals_Null_False() => _five.Equals(null).Should().BeFalse();
    }
}
