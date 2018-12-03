using System.Collections.Generic;

namespace OnlineStore
{
    public class Seller : User
    {
        private const decimal AccountCost = 10;
        public List<Product> Products { get; }

        public override decimal GetCostOfAccount()
        {
            return AccountCost;
        }

        public Seller(string fullName, string username, string password) : base(fullName, username, password)
        {
            Products = new List<Product>();
        }
    }
}