using System;

namespace Person
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = CreatePerson(1);
            Person person2 = CreatePerson(2);
            
            if (person1.Equals(person2))
            {
                Console.WriteLine("They are the same person");
            }
            else
            {
                Console.WriteLine("They are not the same person");
            }

            Console.ReadKey();
        }

        static Person CreatePerson(int index)
        {
            Console.Write($"Please enter the first name of person {index}: ");
            string firstName = Console.ReadLine();

            Console.Write($"Please enter the last name of person {index}: ");
            string lastName = Console.ReadLine();

            return new Person(firstName, lastName);
        }
    }
}