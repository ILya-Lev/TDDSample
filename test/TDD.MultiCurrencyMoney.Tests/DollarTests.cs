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
            var product = five.Times(2);
            product.Amount.Should().Be(10);

            product = five.Times(3);
            product.Amount.Should().Be(15);
        }
    }
}
