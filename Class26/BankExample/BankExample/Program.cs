using System;

namespace BankExample
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount bankAccount = new BankAccount("Mr. Bryan Walton", 11.99);

            bankAccount.Credit(5.77);
            bankAccount.Debit(11.22);
            Console.WriteLine("Current balance is ${0}", bankAccount.Balance);

            Console.ReadKey();
        }
    }
}
