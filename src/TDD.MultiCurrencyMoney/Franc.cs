namespace TDD.MultiCurrencyMoney
{
    public class Franc
    {
        private int Amount { get; }

        public Franc(int amount) => Amount = amount;

        public Franc Times(int factor) => new Franc(Amount * factor);

        public override bool Equals(object other)
        {
            if (object.ReferenceEquals(this, other)) return true;
            if (other == null) return false;

            if (other is Franc otherFranc)
                return this.Amount == otherFranc.Amount;
            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}