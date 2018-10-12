using System;

namespace Example01
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.Write("Please enter a day of the week (Enter \"Stop\" to exit): ");
            string dayOfTheWeek = Console.ReadLine();

            while (dayOfTheWeek.ToLower() != "stop")
            {
                switch (dayOfTheWeek.ToLower())
                {
                    case "monday":
                    case "wednesday":
                    case "thursday":
                        Console.WriteLine("You have class today!");
                        break;
                    case "tuesday":
                    case "friday":
                        Console.WriteLine("You do not have class today!");
                        break;
                    case "saturday":
                    case "sunday":
                        Console.WriteLine("It's the weekend!");
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }

                Console.Write("Please enter a day of the week (Enter \"Stop\" to exit): ");
                dayOfTheWeek = Console.ReadLine();
            }
            
            Console.ReadKey();
        }
    }
}
