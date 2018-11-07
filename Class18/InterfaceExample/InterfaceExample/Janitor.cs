using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExample
{
    class Janitor : IEmployee
    {
        public double GetSalary()
        {
            return 35000;
        }

        public string GetTitle()
        {
            return "Custodial Technician";
        }
    }
}
