using FluentAssertions;
using Xunit;

namespace TDD.MultiCurrencyMoney.Tests
{
    public class DollarTests
    {
        [Fact]
        public void Times_Scalar_ChangesAmount()
        {
            var five = new Dollar(5);
            five.Times(2);
            five.Amount.Should().Be(10);
        }
    }
}
