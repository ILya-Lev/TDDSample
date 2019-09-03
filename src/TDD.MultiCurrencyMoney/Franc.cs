namespace TDD.MultiCurrencyMoney
{
    internal class Franc : Money
    {
        public Franc(int amount, string currency) : base (amount, currency)
        {
        }

        public override Money Times(int factor) => Money.CreateFranc(Amount * factor);
    }
}