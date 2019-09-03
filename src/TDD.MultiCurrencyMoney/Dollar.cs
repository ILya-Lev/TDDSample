namespace TDD.MultiCurrencyMoney
{
    internal class Dollar : Money
    {
        public Dollar(int amount, string currency) : base(amount, currency)
        {
        }

        public override Money Times(int factor) => Money.CreateDollar(Amount * factor);
    }
}
