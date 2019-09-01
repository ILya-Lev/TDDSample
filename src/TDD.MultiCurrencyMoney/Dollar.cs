namespace TDD.MultiCurrencyMoney
{
    public class Dollar
    {
        private int Amount { get; }

        public Dollar(int amount) => Amount = amount;

        public Dollar Times(int factor) => new Dollar(Amount * factor);

        public override bool Equals(object other)
        {
            if (object.ReferenceEquals(this, other)) return true;
            if (other == null) return false;

            if (other is Dollar otherDollar)
                return this.Amount == otherDollar.Amount;
            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
