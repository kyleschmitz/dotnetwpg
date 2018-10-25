using System;

namespace BookExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Book[] books = GetBooks();
            Book largestBook = books[0];

            for (int i = 1; i < books.Length; i++)
            {
                if (books[i].Pages > largestBook.Pages)
                {
                    largestBook = books[i];
                }
            }

            Console.WriteLine($"The largest book is: {largestBook.GetString()}");
            Console.WriteLine($"You will need {largestBook.GetPiecesOfPaper()} pieces of paper to print this book.");
            
            Console.ReadKey();
        }

        static Book[] GetBooks()
        {
            Console.Write("Enter Number of books: ");
            int numberOfBooks = Convert.ToInt32(Console.ReadLine());

            Book[] books = new Book[numberOfBooks];

            for (int i = 0; i < numberOfBooks; i++)
            {
                Console.Write($"Enter name of book {i + 1}: ");
                string name = Console.ReadLine();

                Console.Write($"Enter number of pages for book {i + 1}: ");
                int pages = Convert.ToInt32(Console.ReadLine());

                books[i] = new Book(name, pages);
            }

            return books;
        }
    }
}