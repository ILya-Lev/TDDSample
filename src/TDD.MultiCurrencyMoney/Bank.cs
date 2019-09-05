using System;
using System.Collections.Generic;

namespace TDD.MultiCurrencyMoney
{
	public class Bank
	{
		public Money Reduce(Expression expression, string targetCurrency)
		{
			return expression.Reduce(this, targetCurrency);
		}

		private static readonly Dictionary<string, Dictionary<string, double>> _currencyRates
			= new Dictionary<string, Dictionary<string, double>>(StringComparer.OrdinalIgnoreCase);

		public double GetRate(string fromCurrency, string toCurrency)
		{
			if (fromCurrency.Equals(toCurrency, StringComparison.OrdinalIgnoreCase))
				return 1.0;

			if (_currencyRates.TryGetValue(fromCurrency, out var fromRates))
				if (fromRates.TryGetValue(toCurrency, out var rate))
					return rate;

			throw new Exception($"Cannot find exchange rate from {fromCurrency} to {toCurrency}");
		}

		public void AddRate(string fromCurrency, string toCurrency, double rate)
		{
			DoAddRate(fromCurrency, toCurrency, rate);              //add A -> B
			DoAddRate(toCurrency, fromCurrency, 1 / rate);  //and at the same time B -> A

			void DoAddRate(string @from, string to, double r)
			{
				if (_currencyRates.TryGetValue(@from, out var targetCurrencyRates))
				{
					targetCurrencyRates[to] = r;
					return;
				}

				var targetRates = new Dictionary<string, double>(StringComparer.OrdinalIgnoreCase)
				{
					[to] = r
				};
				_currencyRates[@from] = targetRates;
			}
		}
	}
}