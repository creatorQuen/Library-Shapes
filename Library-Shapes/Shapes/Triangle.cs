using Library_Shapes.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Shapes.Shapes
{
    public class Triangle : ICalculator
    {
        private readonly double _sideA;
        private readonly double _sideB;
        private readonly double _sideC;
        private readonly double _semiPerimeter;

        public Triangle(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            {
                throw new ArgumentException("Sides must be large zero");
            }

            _sideA = sideA;
            _sideB = sideB;
            _sideC = sideC;
            _semiPerimeter = (sideA + sideB + sideC) / 2;

            if (_semiPerimeter < sideA || _semiPerimeter < sideB || _semiPerimeter < sideC)
            {
                throw new ArgumentException("Semiperimeter must be large or equal any side of triangles");
            }
        }

        public double CalculateArea()
        {   
            var result = (_semiPerimeter * (_semiPerimeter - _sideA) * (_semiPerimeter - _sideB) * (_semiPerimeter - _sideC));
            return Math.Pow(result, 0.5);
        }

        public bool IsRightTriangle()
        {
            double maxSide = Math.Max(Math.Max(_sideA, _sideB), _sideC);

            return Math.Pow(maxSide, 2) == (maxSide == _sideA ? (Math.Pow(_sideB, 2) + Math.Pow(_sideC, 2)) :
                                            maxSide == _sideB ? (Math.Pow(_sideA, 2) + Math.Pow(_sideC, 2)) : (Math.Pow(_sideA, 2) + Math.Pow(_sideB, 2)));
        }
    }
}
