using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceExample
{
    public class SoftwareDeveloper : Employee
    {
        public string PrimaryLanguage;
        public double LaptopCost;

        public SoftwareDeveloper(string name, string primaryLanguage, double laptopCost) : base(name)
        {
            PrimaryLanguage = primaryLanguage;
            LaptopCost = laptopCost;
        }
    }
}
