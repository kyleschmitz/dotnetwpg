using System;

namespace GoodExample
{
    public class BankAccount
    {
        public double Balance { get; private set; }
        
        public void DepositAmount(double amount)
        {
            Balance = Balance + amount;
        }

        public bool WithdrawAmount(double amount)
        {
            bool successful;

            if (Balance - amount < 0)
            {
                Console.WriteLine("Insufficient funds.");
                Console.WriteLine($"Account balance is {Balance:c}");
                successful = false;
            }
            else
            {
                Balance = Balance - amount;
                successful = true;
            }

            return successful;
        }
    }
}