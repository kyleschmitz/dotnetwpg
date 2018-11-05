using System;

namespace BadExample
{
    public class Program
    {
        static void Main(String[] args)
        {
            ATM atm = new ATM();
            BankAccount account = new BankAccount();

            Console.WriteLine("Welcome to ComIT bank!");
            atm.PrintMenu();
            int menuChoice = atm.GetMenuChoice();

            while (menuChoice != 5)
            {
                switch (menuChoice)
                {
                    case 1:
                        ShowBalance(account);
                        break;
                    case 2:
                        MakeADeposit(account);
                        break;
                    case 3:
                        MakeAWithdrawal(account);
                        break;
                    case 4:
                        MakeATransfer(account);
                        break;
                    default:
                        Console.WriteLine("Not a valid option");
                        break;
                }

                atm.PrintMenu();
                menuChoice = atm.GetMenuChoice();
            }

            Console.WriteLine("Thanks for using ComIT bank!");
        }

        public static void ShowBalance(BankAccount account)
        {
            Console.WriteLine($"Account balance is {account.Balance:c}");
        }

        public static void MakeADeposit(BankAccount account)
        {
            ATM atm = new ATM();

            double amount = atm.GetAmount();

            if (amount <= 0)
            {
                Console.WriteLine("Invalid amount!");
            }
            else
            {
                account.Balance = account.Balance + amount;
            }
        }

        public static void MakeAWithdrawal(BankAccount account)
        {
            ATM atm = new ATM();

            double amount = atm.GetAmount();

            if (amount <= 0)
            {
                Console.WriteLine("Invalid amount!");
            }
            else
            {
                if (account.Balance - amount < 0)
                {
                    Console.WriteLine("Insufficient funds.");
                    Console.WriteLine($"Account balance is {account.Balance:c}");
                }
                else
                {
                    account.Balance = account.Balance - amount;
                    Console.WriteLine($"Successfully withdrew {account.Balance:c}");
                }
            }
        }

        public static void MakeATransfer(BankAccount account)
        {
            ATM atm = new ATM();

            double amount = atm.GetAmount();

            if (amount <= 0)
            {
                Console.WriteLine("Invalid amount!");
            }
            else
            {
                if (account.Balance - amount < 0)
                {
                    Console.WriteLine("Insufficient funds.");
                    Console.WriteLine($"Account balance is {account.Balance:c}");
                }
                else
                {
                    account.Balance = account.Balance - amount;
                    Console.WriteLine($"Successfully transferred {account.Balance:c}");
                }
            }
        }
    }
}