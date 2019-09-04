namespace TDD.MultiCurrencyMoney
{
	public interface Expression
	{
		Money Reduce(string targetCurrency);
	}
}