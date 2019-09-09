namespace TDD.MultiCurrencyMoney
{
	public interface Expression
	{
		Money Reduce(Bank bank, string targetCurrency);
        Expression Plus(Expression addend);
        Expression Times(double factor);
    }
}