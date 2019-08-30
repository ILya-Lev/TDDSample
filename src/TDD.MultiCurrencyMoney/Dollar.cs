namespace TDD.MultiCurrencyMoney
{
    public class Dollar
    {
        public int Amount { get; }

        public Dollar(int amount) => Amount = amount;

        public Dollar Times(int factor) => new Dollar(Amount * factor);
    }
}
