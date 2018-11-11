using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExample
{
    class Ceo : IEmployee
    {
        public double GetSalary()
        {
            return 1000000;
        }

        public string GetTitle()
        {
            return "The guy that doesn't actually do any work";
        }

        public double GetBonus()
        {
            return 50000;
        }
    }
}
