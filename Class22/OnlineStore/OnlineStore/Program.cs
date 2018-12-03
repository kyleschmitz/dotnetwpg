using System;

namespace OnlineStore
{
    class Program
    {
        static void Main(string[] args)
        {
            Buyer buyer = new Buyer(100, "Bob The Buyer", "bob99", "abc123");
            bool passwordCorrect = false;

            do
            {
                Console.Write("Please enter password: ");
                string password = Console.ReadLine();
                passwordCorrect = buyer.IsPasswordCorrect(password);

                if (!passwordCorrect)
                {
                    Console.WriteLine("Password entered was incorrect!");
                }
            } while (!passwordCorrect);

            Console.WriteLine("Successfully logged in!\r\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
