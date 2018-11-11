using System;

namespace ShapeComparison
{
    public class Circle : IShape
    {
        private double _radius;

        public Circle(double radius)
        {
            _radius = radius;
        }

        public string GetShapeName()
        {
            return "Circle";
        }

        public double CalculateArea()
        {
            return Math.PI * _radius * _radius;
        }
    }
}
