using System;

namespace ShapeComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            IShape circle = new Circle(10);
            Rectangle rectangle = new Rectangle(2, 5);
            IShape triangle = new RightAngleTriangle(4, 5);
            
            PrintAreaForShape(circle);
            PrintAreaForShape(rectangle);
            PrintAreaForShape(triangle);

            bool sameSize = AreTheSameSize(triangle, rectangle);
            if (sameSize)
            {
                Console.WriteLine("They are the same size.");
            }
            else
            {
                Console.WriteLine("They are not the same size.");
            }

            Console.ReadKey();
        }

        static void PrintAreaForShape(IShape shape)
        {
            Console.WriteLine();
            Console.WriteLine($"The area for the {shape.GetShapeName()} is {shape.CalculateArea()}");
        }

        static bool AreTheSameSize(IShape s1, IShape s2)
        {
            return s1.CalculateArea() == s2.CalculateArea();
        }
    }
}
