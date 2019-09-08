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

			var sum = five.Plus(six) as Sum;

			sum.Augend.Should().Be(five);
			sum.Addend.Should().Be(six);
		}

		[Fact]
		public void Reduce_TheSameCurrency_AddAmounts()
		{
			var sum = new Sum(Money.CreateDollar(5), Money.CreateDollar(6));
			var bank = new Bank();
		
			var reduced = bank.Reduce(sum, "USD");
			
			reduced.Equals(Money.CreateDollar(11)).Should().BeTrue();
		}

		[Fact]
		public void Reduce_MoneyOfAlreadyTargetCurrency_InputMoney()
		{
			var bank = new Bank();
			var result = bank.Reduce(Money.CreateDollar(5), "USD");
			result.Equals(Money.CreateDollar(5)).Should().BeTrue();
		}

        [Fact]
        public void Plus_MixedCurrencies_ReduceToCommon()
        {
            Expression fiveUsd = Money.CreateDollar(5);
            Expression tenFrancs = Money.CreateFranc(10);
            var bank = new Bank();
            bank.AddRate("USD", "CHF", 2);

            var sum = fiveUsd.Plus(tenFrancs);
            var usdResult = bank.Reduce(sum, "USD");
            usdResult.Should().Be(Money.CreateDollar(10));

            var chfResult = bank.Reduce(sum, "CHF");
            chfResult.Should().Be(Money.CreateFranc(20));
        }
	}
}