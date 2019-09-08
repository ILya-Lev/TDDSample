using System;

namespace TDD.MultiCurrencyMoney
{
	public class Money : Expression
	{
		public double Amount { get; }
		public string Currency { get; }

		public Money(double amount, string currency)
		{
			Amount = amount;
			Currency = currency;
		}

		public static Money CreateFranc(int amount) => new Money(amount, "CHF");
		public static Money CreateDollar(int amount) => new Money(amount, "USD");

		public Expression Times(int factor) => new Money(Amount * factor, Currency);

		public sealed override bool Equals(object other)
		{
			if (object.ReferenceEquals(this, other)) return true;
			if (other == null) return false;

			if (other is Money money)
				return Amount == money.Amount && Currency == money.Currency;

			return false;
		}

		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public Expression Plus(Expression addend)
		{
			return new Sum(this, addend);
		}

		public Money Reduce(Bank bank, string targetCurrency)
		{
			return new Money(bank.GetRate(Currency, targetCurrency) * Amount, targetCurrency);
		}
	}
}