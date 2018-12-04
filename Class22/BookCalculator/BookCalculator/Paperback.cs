namespace BookCalculator
{
    public class Paperback : Book
    {
        private const double COST_PER_PAGE = 0.02f;

        public Paperback(string title, string author, int numberOfPages) : base(title, author, numberOfPages)
        {
        }

        public override double GetCostOfManufacturing()
        {
            return NumberOfPages * COST_PER_PAGE;
        }
    }
}
