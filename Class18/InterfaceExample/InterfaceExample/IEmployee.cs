using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExample
{
    public interface IEmployee
    {
        void PromoteToPosition(string newPosition);
        double GetSalary();
        string GetTitle();
    }
}
