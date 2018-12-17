namespace BookCalculator
{
    public abstract class Book
    {
        public string Title { get; }
        public string Author { get; }
        public int NumberOfPages { get; }

        public Book(string title, string author, int numberOfPages)
        {
            Title = title;
            Author = author;
            NumberOfPages = numberOfPages;
        }

        public virtual decimal GetCostOfManufacturing()
        {
            return 1;
        }
        
        public override string ToString()
        {
            decimal cost = GetCostOfManufacturing();
            return $"{Title}, by {Author}. Cost to print: {cost:c}";
        }
    }
}
