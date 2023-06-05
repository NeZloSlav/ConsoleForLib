using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary
{
    public static class Geometry
    {
        public static double GetTriangleSquare(double side, double height)
        {
            return Math.Round(side * height / 2, 2);
        }


        public static double GetTriangleSquare(double side1, double side2, double side3)
        {
            double halfPerimetr = (side1 + side2 + side3) / 2;

            return Math.Round(Math.Sqrt(halfPerimetr * (halfPerimetr - side1) * (halfPerimetr - side2) * (halfPerimetr - side3)), 2);
        }

        public static double GetRectangleSquare(double a, double b)
        {
            return a * b;
        }

        public static double GetCircleSquare(double radius)
        {
            return Math.Round(Math.PI * Math.Pow(radius, 2), 2);
        }

        public static double GetTrapezoidSquare(double base1, double base2, double height)
        {
            return Math.Round((base1 + base2) / 2 * height, 2);
        }



    }
}
