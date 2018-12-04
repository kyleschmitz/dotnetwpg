namespace BookCalculator
{
    public class Hardcover : Book
    {
        private const double COST_PER_PAGE = 0.03f;

        public Hardcover(string title, string author, int numberOfPages) : base(title, author, numberOfPages)
        {
        }

        public override double GetCostOfManufacturing()
        {
            return 5 + (NumberOfPages * COST_PER_PAGE);
        }
    }
}
