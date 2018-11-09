using System;
using System.Collections.Generic;
using System.Text;

namespace BankExample
{
    class SavingsAccount : IAccount
    {
        private double _balance;

        public SavingsAccount(double balance)
        {
            _balance = balance;
        }

        public int GetMaxWithdrawals()
        {
            return 20;
        }

        public double GetInterestRate()
        {
            return 2.5f;
        }

        public double GetBalance()
        {
            return _balance;
        }

        public double GetBalancePlusInterest()
        {
            return _balance * (1 + (GetInterestRate() / 100));
        }
    }
}
