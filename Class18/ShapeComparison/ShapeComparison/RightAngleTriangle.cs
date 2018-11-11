namespace ShapeComparison
{
    public class RightAngleTriangle : IShape
    {
        private double _sideA;
        private double _sideB;

        public RightAngleTriangle(double sideA, double sideB)
        {
            _sideA = sideA;
            _sideB = sideB;
        }

        public string GetShapeName()
        {
            return "Triangle";
        }

        public double CalculateArea()
        {
            return (_sideA * _sideB) / 2;
        }
    }
}
