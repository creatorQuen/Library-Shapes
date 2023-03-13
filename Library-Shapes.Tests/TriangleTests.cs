using Library_Shapes.Shapes;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Shapes.Tests
{
    public class TriangleTests
    {
        [TestCase(3, 4, 5, 6)]
        [TestCase(5, 12, 13, 30)]
        [TestCase(39, 80, 89, 1560)]
        public void GetAreaTriangleTests(double sideA, double sideB, double sideC, double expected)
        {
            var triangle = new Triangle(sideA, sideB, sideC);
            var actual = triangle.CalculateArea();

            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 4, 5)]
        [TestCase(3, 0, 5)]
        [TestCase(3, 4, 0)]
        public void GetAreaTriangleTests_AnySideEqualZero_ShouldArgumentException(double sideA, double sideB, double sideC)
        {
            Assert.Throws<ArgumentException>(() => new Triangle(sideA, sideB, sideC));
        }

        [TestCase(1, 1, 5)]
        [TestCase(2, 18, 5)]
        [TestCase(7, 9, 42)]
        public void GetAreaTriangleTests_ParametrTriangleLessAnySide_ShouldArgumentException(double sideA, double sideB, double sideC)
        {
            Assert.Throws<ArgumentException>(() => new Triangle(sideA, sideB, sideC));
        }


        [TestCase(3, 4, 5, true)]
        [TestCase(5, 12, 13, true)]
        [TestCase(39, 80, 89, true)]
        [TestCase(1, 1, 1, false)]
        public void IsRightTriangleTests(double sideA, double sideB, double sideC, bool expected)
        {
            var triangle = new Triangle(sideA, sideB, sideC);
            var actual = triangle.IsRightTriangle();

            Assert.AreEqual(expected, actual);
        }
    }
}
