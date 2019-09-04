namespace TDD.MultiCurrencyMoney
{
	public class Money : Expression
	{
		public int Amount { get; }
		public string Currency { get; }

		public Money(int amount, string currency)
		{
			Amount = amount;
			Currency = currency;
		}

		public static Money CreateFranc(int amount) => new Money(amount, "CHF");
		public static Money CreateDollar(int amount) => new Money(amount, "USD");

		public Money Times(int factor) => new Money(Amount * factor, Currency);

		public sealed override bool Equals(object other)
		{
			if (object.ReferenceEquals(this, other)) return true;
			if (other == null) return false;

			if (other is Money money)
				return Amount == money.Amount && Currency == money.Currency;

			return false;
		}

		//todo: do we really want it to be here?
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public Expression Plus(Money addend)
		{
			return new Sum(this, addend);
		}

		public Money Reduce(string targetCurrency)
		{
			return this;
		}
	}
}