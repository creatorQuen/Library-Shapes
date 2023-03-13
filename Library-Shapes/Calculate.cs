using Library_Shapes.Interfaces;
using Library_Shapes.Shapes;
using System;

namespace Library_Shapes
{
    public class Calculate : IShapes
    {
        public double CalculateShapeArea(ICalculator calculator)
        {
            return calculator.CalculateArea();
        }

        public double GetAreaCircle(double radius)
        {
            var circle = new Circle(radius);
            return CalculateShapeArea(circle);
        }

        public double GetAreaTriangle(double sideA, double sideB, double sideC)
        {
            var triangle = new Triangle(sideA, sideB, sideC);
            return CalculateShapeArea(triangle);
        }

        public bool IsRightTriangle(double sideA, double sideB, double sideC)
        {
            var triangle = new Triangle(sideA, sideB, sideC);
            return triangle.IsRightTriangle();
        }
    }
}
