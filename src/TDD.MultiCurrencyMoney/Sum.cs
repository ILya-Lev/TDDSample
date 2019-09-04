using System;

namespace TDD.MultiCurrencyMoney
{
	public class Sum : Expression
	{
		public Sum(Money augend, Money addend)
		{
			Augend = augend;
			Addend = addend;
		}

		public Money Augend { get; }
		public Money Addend { get; }

		public Money Reduce(string targetCurrency)
		{
			if (Addend.Currency == Augend.Currency
			    && Addend.Currency == targetCurrency)
			{
				var totalAmount = Augend.Amount + Addend.Amount;
				return new Money(totalAmount, targetCurrency);
			}
			throw new NotImplementedException();
		}
	}
}