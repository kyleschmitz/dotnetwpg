using System;

namespace ShapeComparison
{
    public class Rectangle : IShape, IDrawable
    {
        private double _width;
        private double _height;

        public Rectangle(double width, double height)
        {
            _width = width;
            _height = height;
        }

        public string GetShapeName()
        {
            return "Rectangle";
        }

        public double CalculateArea()
        {
            return _width * _height;
        }

        public void DrawShape()
        {
            Console.WriteLine();
            for (int i = 0; i < _height; i++)
            {
                for (int j = 0; j < _width; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
