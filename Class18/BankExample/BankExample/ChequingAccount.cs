using System;
using System.Collections.Generic;
using System.Text;

namespace BankExample
{
    public class ChequingAccount : IAccount
    {
        private double _balance;

        public ChequingAccount(double balance)
        {
            _balance = balance;
        }

        public int GetMaxWithdrawals()
        {
            return 5;
        }

        public double GetInterestRate()
        {
            return 0.5f;
        }

        public double GetBalance()
        {
            return _balance;
        }

        public double GetBalancePlusInterest()
        {
            return _balance * (1 + (GetInterestRate() / 100));
        }

        public void WriteCheque()
        {
            Console.WriteLine("Writing cheque");
        }
    }
}
