using System;

namespace GoodExample
{
    public class Program
    {
        static void Main(String[] args)
        {
            BankAccount account = new BankAccount();

            Console.WriteLine("Welcome to ComIT bank!");
            ATM.PrintMenu();
            int menuChoice = ATM.GetMenuChoice();

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

                ATM.PrintMenu();
                menuChoice = ATM.GetMenuChoice();
            }

            Console.WriteLine("Thanks for using ComIT bank!");
        }

        public static void ShowBalance(BankAccount account)
        {
            Console.WriteLine($"Account balance is {account.Balance:c}");
        }

        public static void MakeADeposit(BankAccount account)
        {
            double amount = ATM.GetAmount();
            account.DepositAmount(amount);
        }

        public static void MakeAWithdrawal(BankAccount account)
        {
            double amount = ATM.GetAmount();

            bool successful = account.WithdrawAmount(amount);
            if (successful)
            {
                Console.WriteLine($"Successfully withdrew {amount:c}");
            }
        }

        public static void MakeATransfer(BankAccount account)
        {
            double amount = ATM.GetAmount();

            bool successful = account.WithdrawAmount(amount);
            if (successful)
            {
                Console.WriteLine($"Successfully transferred {amount:c}");
            }
        }
    }
}