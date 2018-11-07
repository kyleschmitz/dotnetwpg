using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExample
{
    class SoftwareDeveloper : IEmployee
    {
        public double GetSalary()
        {
            return 50000000;
        }

        public string GetTitle()
        {
            return "Full Stack Developer";
        }
    }
}
