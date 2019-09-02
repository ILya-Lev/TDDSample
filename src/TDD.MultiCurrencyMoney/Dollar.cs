namespace TDD.MultiCurrencyMoney
{
    public class Dollar : Money
    {
        public Dollar(int amount) => Amount = amount;

        public Dollar Times(int factor) => new Dollar(Amount * factor);

        protected override bool Equals<TMoney>(TMoney other)
        {
            if (other is Dollar dollar)
                return Amount == dollar.Amount;
            return false;
        }
    }
}
