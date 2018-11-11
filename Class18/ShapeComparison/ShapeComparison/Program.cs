using System;
using System.Diagnostics;

namespace ShapeComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            IShape circle = new Circle(10);
            Rectangle rectangle = new Rectangle(10, 5);
            IShape triangle = new RightAngleTriangle(4, 5);


            IDrawable drawShape = rectangle;


            PrintAreaForShape(circle);
            PrintAreaForShape(rectangle);
            PrintAreaForShape(triangle);

            bool sameSize = AreTheSameSize(triangle, rectangle);
            if (sameSize)
            {
                Console.WriteLine("They are the same");
            }
            else
            {
                Console.WriteLine("They are not the same");
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

        static void DrawShape(IDrawable drawableShape)
        {
            drawableShape.DrawShape();
        }
    }
}
