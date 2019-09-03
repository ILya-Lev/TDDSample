namespace TDD.MultiCurrencyMoney
{
    public abstract class Money
    {
        public static Money Franc(int amount) => new Franc(amount);
        public static Money Dollar(int amount) => new Dollar(amount);

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

        protected int Amount;

    }
}