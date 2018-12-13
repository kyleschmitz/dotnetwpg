using System;

namespace EFCoreExample
{
    class Program
    {
        private const int CHANGE_PRODUCTS = 1;
        private const int CHANGE_SELLERS = 2;
        private const int QUIT = 3;

        static void Main(string[] args)
        {
            bool quit = false;

            while (!quit)
            {
                int menuOption = GetMenuOption();

                switch (menuOption)
                {
                    case CHANGE_PRODUCTS:
                        ProductMenu.Run();
                        break;
                    case CHANGE_SELLERS:
                        SellerMenu.Run();
                        break;
                    case QUIT:
                        quit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid option selected!");
                        break;
                }

                Console.WriteLine();
            }

            Console.WriteLine("Thanks for using the application!");
            Console.ReadKey();
        }

        static int GetMenuOption()
        {
            int menuOption = -1;
            
            Console.WriteLine("Select one of the following options:");
            Console.WriteLine($"{CHANGE_PRODUCTS} - Enter product menu");
            Console.WriteLine($"{CHANGE_SELLERS} - Enter seller menu");
            Console.WriteLine($"{QUIT} - Quit");

            Console.Write("Please enter your selection: ");
            while (!Int32.TryParse(Console.ReadLine(), out menuOption))
            {
                Console.Write("Please enter a valid number: ");
            }

            Console.WriteLine();

            return menuOption;
        }
    }
}
