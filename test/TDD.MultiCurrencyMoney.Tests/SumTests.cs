using FluentAssertions;
using Xunit;

namespace TDD.MultiCurrencyMoney.Tests
{
    public class SumTests
    {
        [Fact]
        public void Plus_AddFiveBucks_FiveBucksMore()
        {
            Expression five = Money.CreateDollar(5);
            Expression ten = Money.CreateFranc(10);
            var bank = new Bank();
            bank.AddRate("USD", "CHF", 2);
            var sum = new Sum(five, ten);
            
            var summedExpression = sum.Plus(five);
            var result = bank.Reduce(summedExpression, "USD");

            result.Should().Be(Money.CreateDollar(15));
        }
    }
}