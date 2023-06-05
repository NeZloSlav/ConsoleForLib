using System.Buffers;

namespace MathLibrary
{
    public static class Algebra
    {
        public static string GetSquareRoots(double a, double b, double c)
        {
            double Discriminant = (b * b) - (4 * a * c);

            if (Discriminant < 0)
            {
                return "Корней нет";
            }
            else if (Discriminant == 0)
            {
                return Math.Round((b / (2 * a) * (-1)),2).ToString();
            }
            else
            {
                return $"{ Math.Round( ( (-1) * b + Math.Sqrt(Discriminant) ) / (2 * a),2)}, { Math.Round(((-1) * b - Math.Sqrt(Discriminant)) / (2 * a), 2)}";
            }
        }

        public static string GetLinearRoots(double a, double b)
        {
            if (a == 0 && b != 0)
            {
                return "Корней нет";
            }
            else if (a == 0 && b == 0)
            {
                return "Корень пренадлежит множеству действительных чисел";
            }
            else
            {
                return $"{Math.Round(b / a * -1, 2)}";
            }
        }

        public static double GetRowSummary(double[] array)
        {
            double summary = 0;

            for (int i = 0; i < array.Length; i++)
            {
                summary += array[i];
            }

            return summary;
        }

        public static double GetMaxFromRow(double[] array)
        {
            double max = array[0];

            for (int i = 0; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                }
            }

            return max;
        }

        public static double GetRowAvg(double[] array)
        {
            return Math.Round(GetRowSummary(array) / array.Length, 2);
        }

    }
}