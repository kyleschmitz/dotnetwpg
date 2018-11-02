using System;

namespace SingletonExample
{
    class Program
    {
        static void Main(string[] args)
        {
            President myPresident = President.CurrentPresident;
            myPresident.Name = "Donald Trump";
            
            President nextPresident = President.CurrentPresident;
            Console.WriteLine(nextPresident.Name);

            Console.ReadKey();
        }
    }
}
