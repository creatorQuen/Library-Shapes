using Library_Shapes.Shapes;
using NUnit.Framework;
using System;

namespace Library_Shapes.Tests
{
    public class CircleTests
    {
        [TestCase(2, 2 * 2 * Math.PI)]
        [TestCase(1, Math.PI)]
        [TestCase(7, 7 * 7 * Math.PI)]
        public void CalculateAreaTest(double radius, double result)
        {
            var circle = new Circle(radius);
            double actual = circle.CalculateArea();

            Assert.AreEqual(result, actual);
        }

        [TestCase(0)]
        [TestCase(-1)]
        [TestCase(-1.1d)]
        public void CalculateAreaTest_ZeroOrNegatieValue_ShouldArgumentException(double radius)
        { 
            Assert.Throws<ArgumentException>(() => new Circle(radius));
        }
    }
}