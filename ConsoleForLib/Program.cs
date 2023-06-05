namespace Program
{
    class Programm
    {
        static void Main()
        {
            Console.WriteLine(MathLibrary.Algebra.GetRowSummary(new double[] {1, 2, 3, 4, 5, 6.03}));
            Console.WriteLine(MathLibrary.Algebra.GetLinearRoots(2, 3));
            Console.WriteLine(MathLibrary.Algebra.GetSquareRoots(2, 3, 4));
            Console.WriteLine(MathLibrary.Algebra.GetMaxFromRow(new double[] {1, 2, 3, 4, 5, 6.03}));
            Console.WriteLine(MathLibrary.Algebra.GetRowAvg(new double[] {1, 2, 3, 4, 5, 6.03}));
            Console.WriteLine(MathLibrary.Geometry.GetTrapezoidSquare(1, 2, 3));
            Console.WriteLine(MathLibrary.Geometry.GetCircleSquare(3));
            Console.WriteLine(MathLibrary.Geometry.GetTriangleSquare(1, 2));
            Console.WriteLine(MathLibrary.Geometry.GetTriangleSquare(2, 3, 2));
            Console.WriteLine(MathLibrary.Geometry.GetRectangleSquare(3, 4));
            Console.WriteLine(MathLibrary.Trigonometry.GetSin(3, 4));
            Console.WriteLine(MathLibrary.Trigonometry.GetCos(3, 4));
            Console.WriteLine(MathLibrary.Trigonometry.GetTang(3, 4));
            Console.WriteLine(MathLibrary.Trigonometry.GetCotang(3, 4));
        }
    }


}
