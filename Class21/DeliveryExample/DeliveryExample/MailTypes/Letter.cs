namespace DeliveryExample.MailTypes
{
    public class Letter : Mail
    {
        public string Contents { get; }

        public Letter(string contents, Address origin, Address destination) : base(origin, destination)
        {
            Contents = contents;
        }

        public override decimal GetCost()
        {
            return 1.25m;
        }
    }
}