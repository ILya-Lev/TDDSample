using FluentAssertions;
using Xunit;

namespace TDD.MultiCurrencyMoney.Tests
{
    public class MoneyTests
    {
        [Fact]
        public void FactoryMethods_ProduceInstancesOfExpectedCurrency()
        {
            Money.CreateDollar(1).Currency.Should().Be("USD");
            Money.CreateFranc(1).Currency.Should().Be("CHF");
        }

        [Fact]
        public void Equals_FrancOfTheSameNoteAsDollar_False()
        {
            var franc = Money.CreateFranc(5);
            var dollar = Money.CreateDollar(5);
            franc.Equals(dollar).Should().BeFalse();
        }

        [Fact]
        public void BankReduce_TheSameCurrency_SumUpAmounts()
        {
            var five = Money.CreateDollar(5);
            var six = Money.CreateDollar(6);
            
            var sum = five.Plus(six);

            var bank = new Bank();
            var reduced = bank.Reduce(sum, "USD");

            reduced.Equals(Money.CreateDollar(11)).Should().BeTrue();
        }

        //[Fact]
        //public void Reduce_SumDollarAndFranc_ResultInDollar()
        //{
        //    var fiveDollar = Money.CreateDollar(5);
        //    var tenFranc = Money.CreateFranc(10);
        //    var bank = new Bank();
            
        //    var reduced = bank.Reduce(fiveDollar, tenFranc, "USD");
            
        //    reduced.Equals(Money.CreateDollar(10)).Should().BeTrue("check CHF to USD exchange rate");
        //}
    }
}