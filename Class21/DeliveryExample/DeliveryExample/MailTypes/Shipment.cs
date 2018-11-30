using System.Collections.Generic;

namespace DeliveryExample.MailTypes
{
    public class Shipment : Mail
    {
        public List<Package> Packages { get; }

        public Shipment(Address origin, Address destination) : base(origin, destination)
        {
            Packages = new List<Package>();
        }

        public override decimal GetCost()
        {
            return 100m;
        }
    }
}