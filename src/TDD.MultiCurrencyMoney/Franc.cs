namespace TDD.MultiCurrencyMoney
{
    internal class Franc : Money
    {
        public Franc(int amount) => Amount = amount;

        public override Money Times(int factor) => new Franc(Amount * factor);
    }
}