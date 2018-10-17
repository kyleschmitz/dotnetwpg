using System;

namespace Rocket
{
    class Program
    {
        static void Main(string[] args)
        {
            bool rocketHasCrashed = false;

            while (!rocketHasCrashed)
            {
                Console.WriteLine();
                Console.WriteLine("***");
                Console.WriteLine();

                int speedInMetersPerSecond = GetTheSpeedOfTheRocket();
                double neededFuel = CalculateNeededFuel((short)speedInMetersPerSecond);

                Console.WriteLine($"Sending {neededFuel} gallons of fuel to the engine to maintain flight!");

                if (neededFuel < 0)
                {
                    rocketHasCrashed = true;
                }
            }

            Console.WriteLine("Oh no! The rocket has crashed! You better start looking for a new job...");
            Console.ReadKey();
        }

        static int GetTheSpeedOfTheRocket()
        {
            int speedInMetersPerSecond;

            Console.Write("Please enter the speed of the rocket in meters per second: ");
            speedInMetersPerSecond = Convert.ToInt32(Console.ReadLine());

            return speedInMetersPerSecond;
        }

        static double CalculateNeededFuel(short speedInMetersPerSecond)
        {
            const double FUEL_RATIO = 0.2;
            double neededFuelInGallons = speedInMetersPerSecond * FUEL_RATIO;

            Console.WriteLine($"Calculating needed fuel for a speed of {speedInMetersPerSecond} meters per second.");
            Console.WriteLine($"Needed fuel in gallons is: {neededFuelInGallons}");

            return neededFuelInGallons;
        }
    }
}
