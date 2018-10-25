using System;

namespace BookExample
{
    class Book
    {
        public string Name;
        public int Pages;
        
        public Book(string name, int pages)
        {
            Name = name;
            Pages = pages;
        }

        public string GetString()
        {
            return $"Book Title: {Name}, number of pages: {Pages}";
        }

        public double GetPiecesOfPaper()
        {
            return (Pages / 2) + (Pages % 2);
        }
    }


}