using System;

namespace ReferenceExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int primitiveVariable = 5;
            Person referenceVariable = new Person("Bob", 50);

            Console.WriteLine($"Original value of primitive variable: {primitiveVariable}");
            ChangePrimitiveType(primitiveVariable);
            Console.WriteLine($"Changed value of primitive variable: {primitiveVariable}");

            Console.WriteLine();

            Console.WriteLine($"Original value of reference variable: {referenceVariable.Name}");
            ChangeReferenceType(referenceVariable);
            Console.WriteLine($"Changed value of reference variable: {referenceVariable.Name}");

            Console.ReadKey();
        }

        static void ChangePrimitiveType(int value)
        {
            value = 10;
        }

        static void ChangeReferenceType(Person person)
        {
            person.Name = "Fred";
        }
    }
}
