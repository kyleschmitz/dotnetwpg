using System;

namespace BankExample
{
    class Program
    {
        static void Main(string[] args)
        {
            ChequingAccount chequingAccount = new ChequingAccount(1000);
            SavingsAccount savingsAccount = new SavingsAccount(1000);
            RRSPAccount rrspAccount = new RRSPAccount(1000, 20);
            
            Console.WriteLine();
            Console.WriteLine("Printing chequing account info:");
            PrintAccountInformation(chequingAccount);
            chequingAccount.WriteCheque();

            Console.WriteLine();
            Console.WriteLine("Printing savings account info:");
            PrintAccountInformation(savingsAccount);

            Console.WriteLine();
            Console.WriteLine("Printing rrsp account info:");
            PrintAccountInformation(rrspAccount);

            Console.ReadKey();
        }

        static void PrintAccountInformation(IAccount account)
        {
            Console.WriteLine("Account information:");
            Console.WriteLine($"Balance: {account.GetBalance()}");
            Console.WriteLine($"Balance with interest is: {account.GetBalancePlusInterest()}");
        }
    }
}
