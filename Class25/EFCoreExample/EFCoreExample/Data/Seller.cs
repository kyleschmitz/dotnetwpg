using System.Collections.Generic;

namespace EFCoreExample.Data
{
    public class Seller
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Product> Products { get; set; }

        public Seller()
        {
            Products = new List<Product>();
        }

        public Seller(string name)
        {
            Name = name;
            Products = new List<Product>();
        }

        public override string ToString()
        {
            string result = $"Seller Id: {Id}, Name: {Name}, Products for sale:";
            foreach (var product in Products)
            {
                result += "\r\n" + product.ToString();
            }

            return result;
        }
    }
}
