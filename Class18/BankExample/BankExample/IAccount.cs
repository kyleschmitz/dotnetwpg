using System;
using System.Collections.Generic;
using System.Text;

namespace BankExample
{
    interface IAccount
    {
        int GetMaxWithdrawals();
        double GetInterestRate();
        double GetBalance();
        double GetBalancePlusInterest();
    }
}
