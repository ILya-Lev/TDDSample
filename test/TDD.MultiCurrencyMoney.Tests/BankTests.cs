using FluentAssertions;
using Xunit;

namespace TDD.MultiCurrencyMoney.Tests
{
	public class BankTests
	{
		[Fact]
		public void Reduce_DifferentCurrency_TheSameCurrency()
		{
			var bank = new Bank();
			bank.AddRate("CHF", "USD", 0.5);      // 2 CHF = 1 USD

			var dollar = bank.Reduce(Money.CreateFranc(2), "USD");

			dollar.Equals(Money.CreateDollar(1)).Should().BeTrue();

			var franc = bank.Reduce(Money.CreateDollar(1), "CHF");

			franc.Should().Be(Money.CreateFranc(2));
		}

	}
}