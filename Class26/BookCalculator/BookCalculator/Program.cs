using System;

namespace BookCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Book[] books = new Book[12];

            CreateBooks(books);

            PrintBooks(books);

            Console.ReadKey();
        }

        static void CreateBooks(Book[] books)
        {
            books[0] = new Paperback("The Odyssey", "Homer", 100);
            books[1] = new Paperback("The Iliad", "Homer", 100);
            books[2] = new Paperback("Ulysses", "James Joyce", 100);
            books[3] = new Paperback("The Great Gatsby", "F. Scott Fitzgerald", 100);
            books[4] = new Paperback("Moby Dick", "Herman Melville", 100);
            
            books[5] = new Hardcover("Hamlet", "William Shakespeare", 100);
            books[6] = new Hardcover("War and Peace", "Leo Tolstoy", 100);
            books[7] = new Hardcover("The Adventures of Huckleberry Finn", "Mark Twain", 100);
            books[8] = new Hardcover("Pride and Prejudice", "Jane Austen", 100);
            books[9] = new Hardcover("The Catcher in the Rye", "J. D. Salinger", 100);

            books[10] = new Magazine("Person of the Year", "Time Magazine", 100);
            books[11] = new Magazine("Top 10 Tourist Destinations", "National Geographic", 200);
        }

        static void PrintBooks(Book[] books)
        {
            for (int i = 0; i < books.Length; i++)
            {
                Console.WriteLine(books[i].ToString());
            }
        }
    }
}
