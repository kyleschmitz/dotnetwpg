using System;

namespace InheritanceExample
{
    public class Employee
    {
        private static int _lastEmployeeNumber = 0;

        public string Name;
        public decimal Salary;
        public DateTime StartDate;
        public int EmployeeNumber;
        
        public Employee(string name)
        {
            Name = name;

            _lastEmployeeNumber++;
            EmployeeNumber = _lastEmployeeNumber;
        }

        public void PrintInformation()
        {
            Console.WriteLine($"{Name} with ID {_lastEmployeeNumber} is making ${Salary}");
        }
    }
}
