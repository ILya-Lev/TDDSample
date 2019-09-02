namespace TDD.MultiCurrencyMoney
{
    public class Franc : Money
    {
        public Franc(int amount) => Amount = amount;

        public Franc Times(int factor) => new Franc(Amount * factor);

        protected override bool Equals<TMoney>(TMoney other)
        {
            if (other is Franc franc)
                return Amount == franc.Amount;
            return false;
        }
    }
}