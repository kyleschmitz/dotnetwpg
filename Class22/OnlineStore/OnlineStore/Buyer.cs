namespace OnlineStore
{
    public class Buyer : User
    {
        private const decimal AccountCost = 5;
        public decimal Balance { get; }
        
        public Buyer(decimal balance, string fullName, string username, string password) : base(fullName, username, password)
        {
            Balance = balance;
        }
        
        public override decimal GetCostOfAccount()
        {
            return AccountCost;
        }
    }
}