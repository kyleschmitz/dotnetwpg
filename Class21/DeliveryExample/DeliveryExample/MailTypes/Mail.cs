namespace DeliveryExample.MailTypes
{
    public abstract class Mail
    {
        public Address Origin { get; }
        public Address Destination { get; }

        public Mail(Address origin, Address destination)
        {
            Origin = origin;
            Destination = destination;
        }

        public string GetInformation()
        {
            return $"Item going from:\r\n   {Origin.GetInformation()}\r\nTo:\r\n   {Destination.GetInformation()}\r\nWith shipping cost: {GetCost():C}";
        }

        public abstract decimal GetCost();
    }
}