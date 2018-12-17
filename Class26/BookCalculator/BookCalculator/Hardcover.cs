using System;

namespace BookCalculator
{
    public class Hardcover : Book
    {
        private const decimal COST_PER_PAGE = 0.03m;

        public Hardcover(string title, string author, int numberOfPages) : base(title, author, numberOfPages)
        {
        }

        public override decimal GetCostOfManufacturing()
        {
            return 5 + (NumberOfPages * COST_PER_PAGE);
        }
    }
}
