using System;

namespace Ascii
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;

            Console.Write("Enter a string to convert: ");
            input = Console.ReadLine();

            Console.WriteLine("The ascii values are: ");
            for (int i = 0; i < input.Length; i++)
            {
                Console.Write((int)input[i]);
                if (i < input.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.ReadKey();
        }
    }
}