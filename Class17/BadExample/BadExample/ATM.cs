using System;

namespace BadExample
{
    public class ATM
    {
        public int GetMenuChoice()
        {
            int menuChoice;

            do
            {
                Console.Write("Please select an option: ");
            } while (!Int32.TryParse(Console.ReadLine(), out menuChoice));

            return menuChoice;
        }

        public double GetAmount()
        {
            double amount;

            do
            {
                Console.Write("Please enter an amount: ");
            } while (!Double.TryParse(Console.ReadLine(), out amount));

            return amount;
        }

        public void PrintMenu()
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