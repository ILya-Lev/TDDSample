namespace TDD.MultiCurrencyMoney
{
    public class Money
    {
        private readonly int _amount;
        public string Currency { get; }

        private Money(int amount, string currency)
        {
            _amount = amount;
            Currency = currency;
        }

        public static Money CreateFranc(int amount) => new Money(amount, "CHF");
        public static Money CreateDollar(int amount) => new Money(amount, "USD");
        
        public Money Times(int factor) => new Money(_amount * factor, Currency);
        
        public sealed override bool Equals(object other)
        {
            if (object.ReferenceEquals(this, other)) return true;
            if (other == null) return false;

            if (other is Money money)
                return _amount == money._amount && Currency == money.Currency;
            
            return false;
        }

        //todo: do we really want it to be here?
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}