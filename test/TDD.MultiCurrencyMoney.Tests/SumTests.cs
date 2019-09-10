using FluentAssertions;
using Xunit;

namespace TDD.MultiCurrencyMoney.Tests
{
    public class SumTests
    {
        private readonly Sum _sum;
        private readonly Bank _bank;

        public SumTests()
        {
            Expression five = Money.CreateDollar(5);
            Expression ten = Money.CreateFranc(10);
            _bank = new Bank();
            _bank.AddRate("USD", "CHF", 2);
            _sum = new Sum(five, ten);
        }

        [Fact]
        public void Plus_AddFiveBucks_FiveBucksMore()
        {
            var summedExpression = _sum.Plus(Money.CreateDollar(5));

            var result = _bank.Reduce(summedExpression, "USD");
            result.Should().Be(Money.CreateDollar(15));
        }

        [Fact]
        public void Times_AddTenFrancsTimes2_CorrectArithmetic()
        {
            var sum = _sum.Times(2);

            var result = _bank.Reduce(sum, "USD");
            result.Should().Be(Money.CreateDollar(20));
        }
    }
}