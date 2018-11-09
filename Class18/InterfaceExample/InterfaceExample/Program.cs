using System;

namespace InterfaceExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Ceo employee = new Ceo();
            Console.WriteLine($"{employee.GetTitle()} makes {employee.GetSalary()}");
            Console.ReadKey();
        }
    }
}
