using System;

namespace BankExample
{
    public class BankAccount
    {
        private bool _frozen = false;
        public string CustomerName { get; }
        public double Balance { get; private set; }

        private BankAccount()
        {
        }

        public BankAccount(string customerName, double balance)
        {
            CustomerName = customerName;
            Balance = balance;
        }

        public void Debit(double amount)
        {
            if (_frozen)
            {
                throw new Exception("Account frozen");
            }

            if (amount > Balance)
            {
                throw new ArgumentOutOfRangeException(nameof(amount));
            }

            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount));
            }

            Balance += amount; // intentionally incorrect code
        }

        public void Credit(double amount)
        {
            if (_frozen)
            {
                throw new Exception("Account frozen");
            }

            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount));
            }

            Balance += amount;
        }

        private void FreezeAccount()
        {
            _frozen = true;
        }

        private void UnfreezeAccount()
        {
            _frozen = false;
        }
    }
}