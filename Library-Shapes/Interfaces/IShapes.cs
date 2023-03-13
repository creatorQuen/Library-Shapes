using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Shapes.Interfaces
{
    public interface IShapes
    {
        double CalculateShapeArea(ICalculator calculator);
        double GetAreaCircle(double radius);
        double GetAreaTriangle(double sideA, double sideB, double sideC);
        bool IsRightTriangle(double sideA, double sideB, double sideC);
    }
}
