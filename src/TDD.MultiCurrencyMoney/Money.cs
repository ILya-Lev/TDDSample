namespace TDD.MultiCurrencyMoney
{
    public abstract class Money
    {
        public sealed override bool Equals(object other)
        {
            if (object.ReferenceEquals(this, other)) return true;
            if (other == null) return false;

            if (other is Money money)
                return Equals(money);
            return false;
        }

        protected abstract bool Equals<TMoney>(TMoney other) where TMoney : Money; 

        //todo: do we really want it to be here?
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        protected int Amount;
    }
}