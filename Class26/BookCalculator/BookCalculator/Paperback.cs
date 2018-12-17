namespace BookCalculator
{
    public class Paperback : Book
    {
        private const decimal COST_PER_PAGE = 0.02m;

        public Paperback(string title, string author, int numberOfPages) : base(title, author, numberOfPages)
        {
        }

        public override decimal GetCostOfManufacturing()
        {
            return NumberOfPages * COST_PER_PAGE;
        }
    }
}
