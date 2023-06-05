using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary
{
    public static class Trigonometry
    {

        public static double GetSin(double cathet, double hypotenuse)
        {
            return Math.Round(cathet / hypotenuse, 2);
        }

        public static double GetCos(double cathet, double hypotenuse)
        {
            return Math.Round(cathet / hypotenuse, 2);
        }

        public static double GetTang(double oppositeCathet, double adjacentCathet)
        {
            return Math.Round(oppositeCathet / adjacentCathet, 2);
        }

        public static double GetCotang(double oppositeCathet, double adjacentCathet)
        {
            return Math.Round(adjacentCathet / oppositeCathet, 2);
        }

        

    }
}
