using System;

namespace InClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MAX_BOOKS = 10;
            const int OPTION_QUIT = 1;
            const int OPTION_CREATE_BOOK = 2;
            const int OPTION_LEND_BOOK = 3;
            const int OPTION_RETURN_BOOK = 4;
            const int OPTION_LIST_ALL_BOOKS = 5;

            int selectedOption = 0;
            int numBooks = 0;
            Book[] books = new Book[MAX_BOOKS];

            while (selectedOption != 1)
            {
                selectedOption = GetMenuOption();

                switch (selectedOption)
                {
                    case OPTION_QUIT:
                        Console.WriteLine("Thanks for using the library!");
                        break;
                    case OPTION_CREATE_BOOK:
                        numBooks = CreateBook(books, numBooks, MAX_BOOKS);
                        break;
                    case OPTION_LEND_BOOK:
                        TakeOutBook(books);
                        break;
                    case OPTION_RETURN_BOOK:
                        ReturnBook(books);
                        break;
                    case OPTION_LIST_ALL_BOOKS:
                        ListAllBooks(books, numBooks);
                        break;
                }
            }

            Console.ReadKey();
        }

        static int CreateBook(Book[] books, int numBooks, int maxBooks)
        {
            Console.WriteLine();
            if (numBooks >= maxBooks)
            {
                Console.WriteLine("Cannot create any more books.");
                return numBooks;
            }

            Console.Write("Enter the title of the book: ");
            string bookTitle = Console.ReadLine();

            Console.Write("Enter the author of the book: ");
            string bookAuthor = Console.ReadLine();

            Console.Write("Enter the number of copies in stock: ");
            int numberOfCopies = 0;
            while (!Int32.TryParse(Console.ReadLine(), out numberOfCopies))
            {
                Console.Write("Please enter a valid number of copies: ");
            }

            books[numBooks] = new Book(bookTitle, bookAuthor, numberOfCopies);

            return numBooks + 1;
        }

        static void TakeOutBook(Book[] books)
        {
            Console.WriteLine();
            Console.Write("Please enter the index of the book to take out: ");
            int index = 0;
            while (!Int32.TryParse(Console.ReadLine(), out index))
            {
                Console.Write("Please enter a valid index: ");
            }

            bool successful = books[index].LendCopy();
            if (!successful)
            {
                Console.WriteLine("No more copies are in stock.");
            }
        }

        static void ReturnBook(Book[] books)
        {
            Console.WriteLine();
            Console.Write("Please enter the index of the book to return: ");
            int index = 0;
            while (!Int32.TryParse(Console.ReadLine(), out index))
            {
                Console.Write("Please enter a valid index: ");
            }

            bool successful = books[index].Return();
            if (!successful)
            {
                Console.WriteLine("Cannot return any more copies.");
            }
        }
        
        static int GetMenuOption()
        {
            int selectedOption = 0;

            Console.WriteLine();
            Console.WriteLine("******************************************");
            Console.WriteLine("Please enter one of the following options:");
            Console.WriteLine("1 - Quit");
            Console.WriteLine("2 - Create a book");
            Console.WriteLine("3 - Take out a book");
            Console.WriteLine("4 - Return a book");
            Console.WriteLine("5 - List all books");
            Console.WriteLine("******************************************");
            Console.Write("Enter your selection: ");

            while (!Int32.TryParse(Console.ReadLine(), out selectedOption) ||
                selectedOption < 1 ||
                selectedOption > 5)
            {
                Console.Write("Please enter a valid number: ");
            }

            return selectedOption;
        }

        static void ListAllBooks(Book[] books, int numBooks)
        {
            Console.WriteLine();

            for (int i = 0; i< numBooks; i++)
            {
                Console.WriteLine(books[i].GetString());
            }
        }
    }
}
