using System.Collections.Generic;

namespace DeliveryExample.MailTypes
{
    public class Package : Mail
    {
        public List<Product> Products { get; }

        public Package(Address origin, Address destination) : base(origin, destination)
        {
            Products = new List<Product>();
        }

        public override decimal GetCost()
        {
            return 10 * Products.Count;
        }

        public string GetProductInformation()
        {
            string information = "Package contains: ";

            for (int i = 0; i < Products.Count; i++)
            {
                information += Products[i].Name;

                if (i < Products.Count - 1)
                    information += ", ";
            }

            return information;
        }
    }
}