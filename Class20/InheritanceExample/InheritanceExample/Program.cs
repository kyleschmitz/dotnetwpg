using System;

namespace InheritanceExample
{
    class Program
    {
        public static void Main(string[] args)
        {
            SoftwareDeveloper developer = new SoftwareDeveloper("Bob", "C#", 500);
            developer.Salary = 50000;
            developer.StartDate = new DateTime(2018, 10, 1);
            developer.PrintInformation();
            
            CEO ceo = new CEO("Fred", 100000);
            ceo.Salary = 10000000;
            ceo.PrintInformation();

            Console.ReadKey();
        }
    }
}
