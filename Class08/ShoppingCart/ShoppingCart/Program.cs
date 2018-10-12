using System;

namespace ShoppingCart
{
    class Program
    {
        static void Main(string[] args)
        {
            string itemName = GetItemName();
            decimal itemPrice = GetItemPrice();
            int taxPercent = GetTaxPercentage();
            
            decimal itemTax = itemPrice * ((decimal)taxPercent / 100);
            decimal total = itemPrice + itemTax;

            PrintItemInformation(itemName, itemPrice, taxPercent, itemTax, total);

            decimal payment = AskForPayment(total);

            PrintReceipt(payment, total);

            Console.WriteLine("Thank you for visiting the store!");
            Console.ReadKey();
        }

        static string GetItemName()
        {
            Console.Write("Please enter the item name: ");
            string itemName = Console.ReadLine();
            return itemName;
        }

        static decimal GetItemPrice()
        {
            decimal itemPrice;
            Console.Write("Please enter the item price: ");
            while (!Decimal.TryParse(Console.ReadLine(), out itemPrice))
            {
                Console.Write("Invalid input. Please enter a valid price: ");
            }

            return itemPrice;
        }

        static int GetTaxPercentage()
        {
            Console.Write("Please enter the tax percentage: ");
            int taxRate;
            while (!Int32.TryParse(Console.ReadLine(), out taxRate))
            {
                Console.Write("Invalid input. Please enter a valid tax rate: ");
            }

            return taxRate;
        }

        static void PrintItemInformation(string itemName, decimal itemPrice, int taxPercent, decimal itemTax, decimal total)
        {
            Console.WriteLine("");
            Console.WriteLine("The item name is: " + itemName);
            Console.WriteLine($"The price of the item is: {itemPrice:c2}");
            Console.WriteLine($"The tax on the item is: {itemTax:c2}");
            Console.WriteLine($"The total amount owed is: {total:c2}");
        }

        static decimal AskForPayment(decimal total)
        {
            decimal payment;
            
            Console.WriteLine("");
            do
            {
                Console.Write($"Total is {total:c2}, please enter amount of payment: ");

                while (!Decimal.TryParse(Console.ReadLine(), out payment))
                {
                    Console.Write("Invalid input. Please enter a valid payment: ");
                }

                if (payment < total)
                {
                    Console.WriteLine($"Insufficient funds. Please try again!");
                }
            } while (payment < total);

            return payment;
        }

        static void PrintReceipt(decimal payment, decimal total)
        {
            Console.WriteLine("");
            Console.WriteLine($"The amount received is: {payment:c2}");
            Console.WriteLine($"The amount of change owed is : {(payment - total):c2}");
        }
    }
}
