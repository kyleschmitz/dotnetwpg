using System;

namespace Bicycle
{
    class Program
    {
        static void Main(string[] args)
        {
            Bicycle[] bicycles = new Bicycle[5];

            for (int i = 0; i < bicycles.Length; i++)
            {
                bicycles[i] = new Bicycle();
                Console.WriteLine($"Current Bike Id: {bicycles[i].Id}");
            }

            Console.WriteLine($"Last Id: {Bicycle.GetLastId()}");
            Console.ReadKey();
        }
    }
}