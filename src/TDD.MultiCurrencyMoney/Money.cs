namespace TDD.MultiCurrencyMoney
{
    public abstract class Money
    {
        protected int Amount;
        protected string Currency;

        protected Money(int amount, string currency)
        {
            Amount = amount;
            Currency = currency;
        }

        public static Money CreateFranc(int amount) => new Franc(amount, "CHF");
        public static Money CreateDollar(int amount) => new Dollar(amount, "USD");

        public string GetCurrency() => Currency;

        public abstract Money Times(int factor);
        
        public sealed override bool Equals(object other)
        {
            if (object.ReferenceEquals(this, other)) return true;
            if (other == null) return false;

            if (GetType() != other.GetType())   //todo: this type comparison should lead us to Currency concept 
                return false;

            return Amount == (other as Money).Amount;
        }
        
        //todo: do we really want it to be here?
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}