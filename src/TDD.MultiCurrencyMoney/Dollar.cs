namespace TDD.MultiCurrencyMoney
{
    internal class Dollar : Money
    {
        public Dollar(int amount) => Amount = amount;

        public override Money Times(int factor) => new Dollar(Amount * factor);
    }
}
