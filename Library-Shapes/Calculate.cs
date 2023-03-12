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

        /// <summary>
        /// Calculate the area of a circle.
        /// </summary>
        /// <param name="radius"></param>
        /// <returns>The area of a circle.</returns>
        public double GetAreaCircle(double radius)
        {
            var circle = new Circle(radius);
            return CalculateShapeArea(circle);
        }
    }
}
