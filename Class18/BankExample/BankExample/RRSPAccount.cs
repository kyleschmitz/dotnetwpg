using System;
using System.Collections.Generic;
using System.Text;

namespace BankExample
{
    class RRSPAccount : IAccount
    {
        private double _balance;
        private int _years;

        public RRSPAccount(double balance, int years)
        {
            _balance = balance;
            _years = years;
        }

        public int GetMaxWithdrawals()
        {
            return 0;
        }

        public double GetInterestRate()
        {
            return 9f;
        }

        public double GetBalance()
        {
            return _balance;
        }

        public double GetBalancePlusInterest()
        {
            double total = _balance;
            for (int i = 0; i < _years; i++)
            {
                total *= (1 + (GetInterestRate() / 100));
            }

            return total;
        }
    }
}
