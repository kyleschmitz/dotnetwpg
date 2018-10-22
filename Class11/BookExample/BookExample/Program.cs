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

            Console.Write($"The largest book is: ");
            Console.WriteLine(largestBook.GetBookInformation());

            Console.ReadKey();
        }

        static Book[] GetBooks()
        {
            Console.Write("Enter Number of books: ");
            int numberOfBooks = Convert.ToInt32(Console.ReadLine());
            Book[] books = new Book[numberOfBooks];

            for (int i = 0; i < numberOfBooks; i++)
            {
                books[i] = new Book();

                Console.Write($"Enter name of book {i + 1}: ");
                books[i].Name = Console.ReadLine();
                
                Console.Write($"Enter number of pages for book {i + 1}: ");
                books[i].Pages = Convert.ToInt32(Console.ReadLine());
                
            }

            return books;
        }
    }
}