using System;

namespace InterfaceExample
{
    class Program
    {
        static void Main(string[] args)
        {
            IEmployee employee = new Ceo();

            Console.WriteLine($"{employee.GetTitle()} makes {employee.GetSalary()}");
            Console.ReadKey();
        }
    }
}
