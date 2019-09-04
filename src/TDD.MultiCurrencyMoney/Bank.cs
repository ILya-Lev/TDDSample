using System;

namespace TDD.MultiCurrencyMoney
{
	public class Bank
	{
		public Money Reduce(Expression expression, string targetCurrency)
		{
			return expression.Reduce(targetCurrency);
		}
	}
}