namespace TDD.MultiCurrencyMoney
{
    public class Dollar
    {
        public int Amount { get; private set; }

        public Dollar(int amount)
        {
            Amount = amount;
        }
        
        public void Times(int factor)
        {
            Amount *= factor;
        }
    }
}
