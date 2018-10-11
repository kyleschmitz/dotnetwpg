using System;

namespace PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberToCheck;
            bool isNumberPrime;

            numberToCheck = PromptForNumber();

            while(numberToCheck != -1)
            {
            	isNumberPrime = IsNumberPrime(numberToCheck);

            	if (isNumberPrime)
            	{
            		Console.WriteLine(numberToCheck + " is prime!");
            	}
            	else
            	{
            		Console.WriteLine(numberToCheck + " is not prime!");
            	}

            	numberToCheck = PromptForNumber();
            }
        }

        static int PromptForNumber()
        {
        	int numberToCheck;

        	Console.Write("Enter a number to check! (-1 to quit): ");

        	numberToCheck = Convert.ToInt32(Console.ReadLine());

        	return numberToCheck;
        }

        static bool IsNumberPrime(int num)
        {
        	int counter = 2;
        	bool isNumberPrime = true;
        	int remainder;

        	while (counter < num && isNumberPrime)
        	{
        		remainder = num % counter;

        		if (remainder == 0)
        		{
        			isNumberPrime = false;
        		}

        		counter = counter + 1;
        	}

        	return isNumberPrime;
        }
    }
}
