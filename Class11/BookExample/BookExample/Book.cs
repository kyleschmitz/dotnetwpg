using System;

namespace BookExample
{
    class Book
    {
        public string Name;
        public int Pages;

        public string GetBookInformation()
        {
            return $"Book Title: {Name}, number of pages: {Pages}";
        }
    }


}