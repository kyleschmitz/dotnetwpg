using System;

namespace BookExample
{
    class Book
    {
        public string Name;
        public int pages;

        public void PrintBookInformation()
        {
            Console.WriteLine($"Book Title: {Name}, number of pages: {pages}");
        }
    }


}