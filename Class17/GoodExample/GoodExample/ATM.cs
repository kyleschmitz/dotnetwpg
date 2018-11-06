using System;

namespace GoodExample
{
    public class ATM
    {
        public static int GetMenuChoice()
        {
            int menuChoice;

            do
            {
                Console.Write("Please select an option: ");
            } while (!Int32.TryParse(Console.ReadLine(), out menuChoice));

            return menuChoice;
        }

        public static double GetAmount()
        {
            double amount = 0;
            bool isValidAmount = false;

            while (!isValidAmount)
            {
                Console.Write("Please enter an amount: ");
                bool isNumber = Double.TryParse(Console.ReadLine(), out amount);

                if (!isNumber || amount <= 0)
                    Console.WriteLine("Number entered is invalid!");
                else
                    isValidAmount = true;
            }

            return amount;
        }

        public static void PrintMenu()
        {
            Console.WriteLine();
            Console.WriteLine("**************");
            Console.WriteLine();
            Console.WriteLine("Available options:");
            Console.WriteLine("1 - Show balance");
            Console.WriteLine("2 - Make a deposit");
            Console.WriteLine("3 - Make a withdrawal");
            Console.WriteLine("4 - Make a transfer");
            Console.WriteLine("5 - Quit");
            Console.WriteLine();
        }
    }
}