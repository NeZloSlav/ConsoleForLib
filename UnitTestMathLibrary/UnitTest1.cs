namespace UnitTestMathLibrary
{
    [TestClass]
    public class UnitTest1
    {
        #region Algebra


        [TestMethod]
        public void GetSquareRootsTest1()
        {
            //Arrange
            double a = 1;
            double b = 2;
            double c = 0;
            string roots = "0, -2";

            //Act
            string result = MathLibrary.Algebra.GetSquareRoots(a, b, c);

            //Assert
            Assert.AreEqual(roots, result);
        }

        [TestMethod]
        public void GetSquareRootsTest2()
        {
            //Arrange
            double a = 1;
            double b = 2;
            double c = 1;
            string roots = "-1";

            //Act
            string result = MathLibrary.Algebra.GetSquareRoots(a, b, c);

            //Assert
            Assert.AreEqual(roots, result);
        }

        [TestMethod]
        public void GetSquareRootsTest3()
        {
            //Arrange
            double a = -1;
            double b = 0;
            double c = 1;
            string roots = "-1, 1";

            //Act
            string result = MathLibrary.Algebra.GetSquareRoots(a, b, c);

            //Assert
            Assert.AreEqual(roots, result);
        }

        [TestMethod]
        public void GetSquareRootsTest4()
        {
            //Arrange
            double a = -1;
            double b = 0;
            double c = -2;
            string roots = "Корней нет";

            //Act
            string result = MathLibrary.Algebra.GetSquareRoots(a, b, c);

            //Assert
            Assert.AreEqual(roots, result);
        }

        [TestMethod]
        public void GetSquareRootsTest5()
        {
            //Arrange
            double a = 1;
            double b = 2;
            double c = -3;
            string roots = "1, -3";

            //Act
            string result = MathLibrary.Algebra.GetSquareRoots(a, b, c);

            //Assert
            Assert.AreEqual(roots, result);
        }

        [TestMethod]
        public void GetLinearRootsTest1()
        {
            //Arrange

            double a = 1.5;
            double b = 4.5;

            string res = "-3";


            //Act

            string methodRes = MathLibrary.Algebra.GetLinearRoots(a, b);

            //Assert

            Assert.AreEqual(res, methodRes);
        }

        [TestMethod]
        public void GetLinearRootsTest2()
        {
            //Arrange

            double a = 3;
            double b = 9;

            string res = "-3";


            //Act

            string methodRes = MathLibrary.Algebra.GetLinearRoots(a, b);

            //Assert

            Assert.AreEqual(res, methodRes);
        }

        [TestMethod]
        public void GetLinearRootsTest3()
        {
            //Arrange

            double a = 0;
            double b = 8;

            string res = "Корней нет";


            //Act

            string methodRes = MathLibrary.Algebra.GetLinearRoots(a, b);

            //Assert

            Assert.AreEqual(res, methodRes);
        }

        [TestMethod]
        public void GetLinearRootsTest4()
        {
            //Arrange

            double a = 0;
            double b = 0;

            string res = "Корень пренадлежит множеству действительных чисел";


            //Act

            string methodRes = MathLibrary.Algebra.GetLinearRoots(a, b);

            //Assert

            Assert.AreEqual(res, methodRes);
        }

        [TestMethod]
        public void GetLinearRootsTest5()
        {
            //Arrange

            double a = -2;
            double b = -4;

            string res = "-2";


            //Act

            string methodRes = MathLibrary.Algebra.GetLinearRoots(a, b);

            //Assert

            Assert.AreEqual(res, methodRes);
        }

        [TestMethod]
        public void GetRowSummaryTest1()
        {
            //Arrange

            double[] array = { 1.0, 2.25, 3, 0, -4, 5, 5.75 };

            double result = 13;

            //Act

            double methodRes = MathLibrary.Algebra.GetRowSummary(array);

            //Asset

            Assert.AreEqual(result, methodRes);
        }

        [TestMethod]
        public void GetRowSummaryTest2()
        {
            //Arrange

            double[] array = { 1, 2};

            double result = 3;

            //Act

            double methodRes = MathLibrary.Algebra.GetRowSummary(array);

            //Asset

            Assert.AreEqual(result, methodRes);
        }

        [TestMethod]
        public void GetRowSummaryTest3()
        {
            //Arrange

            double[] array = { 0};

            double result = 0;

            //Act

            double methodRes = MathLibrary.Algebra.GetRowSummary(array);

            //Asset

            Assert.AreEqual(result, methodRes);
        }

        [TestMethod]
        public void GetRowSummaryTest4()
        {
            //Arrange

            double[] array = { 0.10, 0.20, 0.30, 0.40};

            double result = 1;

            //Act

            double methodRes = MathLibrary.Algebra.GetRowSummary(array);

            //Asset

            Assert.AreEqual(result, methodRes);
        }

        [TestMethod]
        public void GetRowSummaryTest5()
        {
            //Arrange

            double[] array = { -0.10, -0.20, -0.30, -0.40 };

            double result = -1;

            //Act

            double methodRes = MathLibrary.Algebra.GetRowSummary(array);

            //Asset

            Assert.AreEqual(result, methodRes);
        }

        [TestMethod]
        public void GetMaxFromRowTest1()
        {
            //Arrange

            double[] array = { 1,5,32,7,9,-100.33, 432.4 };

            double result = 432.4;

            //Act

            double methodRes = MathLibrary.Algebra.GetMaxFromRow(array);

            //Asset

            Assert.AreEqual(result, methodRes);
        }

        [TestMethod]
        public void GetMaxFromRowTest2()
        {
            //Arrange

            double[] array = { 0, 0, 0, 0, 0, 0 };

            double result = 0;

            //Act

            double methodRes = MathLibrary.Algebra.GetMaxFromRow(array);

            //Asset

            Assert.AreEqual(result, methodRes);
        }

        [TestMethod]
        public void GetMaxFromRowTest3()
        {
            //Arrange

            double[] array = { 4, 6, 4, 3, 7, 7 };

            double result = 7;

            //Act

            double methodRes = MathLibrary.Algebra.GetMaxFromRow(array);

            //Asset

            Assert.AreEqual(result, methodRes);
        }

        [TestMethod]
        public void GetMaxFromRowTest4()
        {
            //Arrange

            double[] array = { 1.23, 4.56, -5.34, 10, 23.444 };

            double result = 23.444;

            //Act

            double methodRes = MathLibrary.Algebra.GetMaxFromRow(array);

            //Asset

            Assert.AreEqual(result, methodRes);
        }

        [TestMethod]
        public void GetMaxFromRowTest5()
        {
            //Arrange

            double[] array = { -23.2, -5.4, -29.34, -0.45, -10 };

            double result = -0.45;

            //Act

            double methodRes = MathLibrary.Algebra.GetMaxFromRow(array);

            //Asset

            Assert.AreEqual(result, methodRes);
        }

        [TestMethod]
        public void GetRowAvgTest1()
        {
            //Arrange

            double[] array = { 1, 2, 3, 4, 5 };

            double result = 3;

            //Act

            double methodRes = MathLibrary.Algebra.GetRowAvg(array);

            //Asset

            Assert.AreEqual(result, methodRes);
        }

        [TestMethod]
        public void GetRowAvgTest2()
        {
            //Arrange

            double[] array = { 0.23, 45.23, 2, 23.1 };

            double result = 17.64;

            //Act

            double methodRes = MathLibrary.Algebra.GetRowAvg(array);

            //Asset

            Assert.AreEqual(result, methodRes);
        }

        [TestMethod]
        public void GetRowAvgTest3()
        {
            //Arrange

            double[] array = { 2, 3, 4, 5, 6 };

            double result = 4;

            //Act

            double methodRes = MathLibrary.Algebra.GetRowAvg(array);

            //Asset

            Assert.AreEqual(result, methodRes);
        }

        [TestMethod]
        public void GetRowAvgTest4()
        {
            //Arrange

            double[] array = { 1, 2, 3, 4, 5, 6 };

            double result = 3.5;

            //Act

            double methodRes = MathLibrary.Algebra.GetRowAvg(array);

            //Asset

            Assert.AreEqual(result, methodRes);
        }

        [TestMethod]
        public void GetRowAvgTest5()
        {
            //Arrange

            double[] array = {1.23, 2.34, 45, 54.8 };

            double result = 25.8425;

            //Act

            double methodRes = MathLibrary.Algebra.GetRowAvg(array);

            //Asset

            Assert.AreEqual(result, methodRes);
        }



        #endregion

        #region Geometry
        [TestMethod]
        public void GetTriangleSquareTest1()
        {
            //Arrange
            double side = 3;
            double height = 4;
            double square = 6;

            //Act
            double result = MathLibrary.Geometry.GetTriangleSquare(side, height);

            //Assert
            Assert.AreEqual(square, result);
        }

        [TestMethod]
        public void GetTriangleSquareTest2()
        {
            //Arrange
            double side = 2.3;
            double height = 4.4;
            double square = 4.84;

            //Act
            double result = MathLibrary.Geometry.GetTriangleSquare(side, height);

            //Assert
            Assert.AreEqual(square, result);
        }

        [TestMethod]
        public void GetTriangleSquareTest3()
        {
            //Arrange
            double side = 7;
            double height = 0;
            double square = 0;

            //Act
            double result = MathLibrary.Geometry.GetTriangleSquare(side, height);

            //Assert
            Assert.AreEqual(square, result);
        }

        [TestMethod]
        public void GetTriangleSquareTest4()
        {
            //Arrange
            double side = 2;
            double height = 5;
            double square = 5;

            //Act
            double result = MathLibrary.Geometry.GetTriangleSquare(side, height);

            //Assert
            Assert.AreEqual(square, result);
        }

        [TestMethod]
        public void GetTriangleSquareTest5()
        {
            //Arrange
            double side = 6;
            double height = 4;
            double square = 12;

            //Act
            double result = MathLibrary.Geometry.GetTriangleSquare(side, height);

            //Assert
            Assert.AreEqual(square, result);
        }

        [TestMethod]
        public void GetTriangleSquare2Test1()
        {
            //Arrange
            double side1 = 3;
            double side2 = 4;
            double side3 = 5;
            double square = 6;

            //Act
            double result = MathLibrary.Geometry.GetTriangleSquare(side1, side2, side3);

            //Assert
            Assert.AreEqual(square, result);
        }

        [TestMethod]
        public void GetTriangleSquare2Test2()
        {
            //Arrange
            double side1 = 5;
            double side2 = 2;
            double side3 = 6;
            double square = 4.684;

            //Act
            double result = MathLibrary.Geometry.GetTriangleSquare(side1, side2, side3);

            //Assert
            Assert.AreEqual(square, result);
        }

        [TestMethod]
        public void GetTriangleSquare2Test3()
        {
            //Arrange
            double side1 = 3;
            double side2 = 6;
            double side3 = 5;
            double square = 7.483;

            //Act
            double result = MathLibrary.Geometry.GetTriangleSquare(side1, side2, side3);

            //Assert
            Assert.AreEqual(square, result);
        }

        [TestMethod]
        public void GetTriangleSquare2Test4()
        {
            //Arrange
            double side1 = 3.4;
            double side2 = 2.4;
            double side3 = 4.3;
            double square = 4.07;

            //Act
            double result = MathLibrary.Geometry.GetTriangleSquare(side1, side2, side3);

            //Assert
            Assert.AreEqual(square, result);
        }

        [TestMethod]
        public void GetTriangleSquare2Test5()
        {
            //Arrange
            double side1 = 3.5;
            double side2 = 4;
            double side3 = 4;
            double square = 6.295;

            //Act
            double result = MathLibrary.Geometry.GetTriangleSquare(side1, side2, side3);

            //Assert
            Assert.AreEqual(square, result);
        }

        [TestMethod]
        public void GetRectangleSquareTest1()
        {
            //Arrange
            double a = 2;
            double b = 4;
            double square = 8;

            //Act
            double result = MathLibrary.Geometry.GetTriangleSquare(a, b);

            //Assert
            Assert.AreEqual(square, result);
        }

        [TestMethod]
        public void GetRectangleSquareTest2()
        {
            //Arrange
            double a = 4.23;
            double b = 1;
            double square = 4.23;

            //Act
            double result = MathLibrary.Geometry.GetTriangleSquare(a, b);

            //Assert
            Assert.AreEqual(square, result);
        }

        [TestMethod]
        public void GetRectangleSquareTest3()
        {
            //Arrange
            double a = 5;
            double b = 6;
            double square = 30;

            //Act
            double result = MathLibrary.Geometry.GetTriangleSquare(a, b);

            //Assert
            Assert.AreEqual(square, result);
        }

        [TestMethod]
        public void GetRectangleSquareTest4()
        {
            //Arrange
            double a = 9;
            double b = 11;
            double square = 99;

            //Act
            double result = MathLibrary.Geometry.GetTriangleSquare(a, b);

            //Assert
            Assert.AreEqual(square, result);
        }

        [TestMethod]
        public void GetRectangleSquareTest5()
        {
            //Arrange
            double a = 4;
            double b = 8;
            double square = 32;

            //Act
            double result = MathLibrary.Geometry.GetTriangleSquare(a, b);

            //Assert
            Assert.AreEqual(square, result);
        }

        [TestMethod]
        public void GetCircleSquareTest1()
        {
            //Arrange
            double radius = 5;
            double square = 78.5;

            //Act
            double result = MathLibrary.Geometry.GetCircleSquare(radius);

            //Assert
            Assert.AreEqual(square, result);
        }

        [TestMethod]
        public void GetCircleSquareTest2()
        {
            //Arrange
            double radius = 2;
            double square = 12.56;

            //Act
            double result = MathLibrary.Geometry.GetCircleSquare(radius);

            //Assert
            Assert.AreEqual(square, result);
        }

        [TestMethod]
        public void GetCircleSquareTest3()
        {
            //Arrange
            double radius = 9;
            double square = 254.34;

            //Act
            double result = MathLibrary.Geometry.GetCircleSquare(radius);

            //Assert
            Assert.AreEqual(square, result);
        }

        [TestMethod]
        public void GetCircleSquareTest4()
        {
            //Arrange
            double radius = 8.5;
            double square = 226.865;

            //Act
            double result = MathLibrary.Geometry.GetCircleSquare(radius);

            //Assert
            Assert.AreEqual(square, result);
        }

        [TestMethod]
        public void GetCircleSquareTest5()
        {
            //Arrange
            double radius = 1.4;
            double square = 6.1544;

            //Act
            double result = MathLibrary.Geometry.GetCircleSquare(radius);

            //Assert
            Assert.AreEqual(square, result);
        }

        [TestMethod]
        public void GetTrapezoidSquareTest1()
        {
            //Arrange
            double base1 = 2;
            double base2 = 3;
            double height = 4;
            double square = 10;

            //Act
            double result = MathLibrary.Geometry.GetTrapezoidSquare(base1, base2, height);

            //Assert
            Assert.AreEqual(square, result);
        }

        [TestMethod]
        public void GetTrapezoidSquareTest2()
        {
            //Arrange
            double base1 = 5;
            double base2 = 3.2;
            double height = 6;
            double square = 24.6;

            //Act
            double result = MathLibrary.Geometry.GetTrapezoidSquare(base1, base2, height);

            //Assert
            Assert.AreEqual(square, result);
        }

        [TestMethod]
        public void GetTrapezoidSquareTest3()
        {
            //Arrange
            double base1 = 2;
            double base2 = 3.2;
            double height = 4;
            double square = 10.4;

            //Act
            double result = MathLibrary.Geometry.GetTrapezoidSquare(base1, base2, height);

            //Assert
            Assert.AreEqual(square, result);
        }

        [TestMethod]
        public void GetTrapezoidSquareTest4()
        {
            //Arrange
            double base1 = 10;
            double base2 = 8.5;
            double height = 5;
            double square = 46.25;

            //Act
            double result = MathLibrary.Geometry.GetTrapezoidSquare(base1, base2, height);

            //Assert
            Assert.AreEqual(square, result);
        }

        [TestMethod]
        public void GetTrapezoidSquareTest5()
        {
            //Arrange
            double base1 = 2;
            double base2 = 3;
            double height = 0;
            double square = 0;

            //Act
            double result = MathLibrary.Geometry.GetTrapezoidSquare(base1, base2, height);

            //Assert
            Assert.AreEqual(square, result);
        }

        [TestMethod]
        public void GetSinTest1()
        {
            //Arrange
            double cathet = 6;
            double hypotenuse = 3;
            double sin = 2;

            //Act
            double result = MathLibrary.Trigonometry.GetSin(cathet, hypotenuse);

            //Assert
            Assert.AreEqual(sin, result);
        }

        [TestMethod]
        public void GetSinTest2()
        {
            //Arrange
            double cathet = 3;
            double hypotenuse = 6;
            double sin = 1.5;

            //Act
            double result = MathLibrary.Trigonometry.GetSin(cathet, hypotenuse);

            //Assert
            Assert.AreEqual(sin, result);
        }

        [TestMethod]
        public void GetSinTest3()
        {
            //Arrange
            double cathet = 4;
            double hypotenuse = 2;
            double sin = 2;

            //Act
            double result = MathLibrary.Trigonometry.GetSin(cathet, hypotenuse);

            //Assert
            Assert.AreEqual(sin, result);
        }

        [TestMethod]
        public void GetSinTest4()
        {
            //Arrange
            double cathet = 9;
            double hypotenuse = 3;
            double sin = 3;

            //Act
            double result = MathLibrary.Trigonometry.GetSin(cathet, hypotenuse);

            //Assert
            Assert.AreEqual(sin, result);
        }

        [TestMethod]
        public void GetSinTest5()
        {
            //Arrange
            double cathet = 10;
            double hypotenuse = 2;
            double sin = 5;

            //Act
            double result = MathLibrary.Trigonometry.GetSin(cathet, hypotenuse);

            //Assert
            Assert.AreEqual(sin, result);
        }

        [TestMethod]
        public void GetCosTest1()
        {
            //Arrange
            double cathet = 10;
            double hypotenuse = 2;
            double sin = 5;

            //Act
            double result = MathLibrary.Trigonometry.GetSin(cathet, hypotenuse);

            //Assert
            Assert.AreEqual(sin, result);
        }

        [TestMethod]
        public void GetCosTest2()
        {
            //Arrange
            double cathet = 3;
            double hypotenuse = 6;
            double sin = 1.5;

            //Act
            double result = MathLibrary.Trigonometry.GetCos(cathet, hypotenuse);

            //Assert
            Assert.AreEqual(sin, result);
        }

        [TestMethod]
        public void GetCosTest3()
        {
            //Arrange
            double cathet = 4;
            double hypotenuse = 2;
            double sin = 2;

            //Act
            double result = MathLibrary.Trigonometry.GetCos(cathet, hypotenuse);

            //Assert
            Assert.AreEqual(sin, result);
        }

        [TestMethod]
        public void GetCosTest4()
        {
            //Arrange
            double cathet = 9;
            double hypotenuse = 3;
            double sin = 3;

            //Act
            double result = MathLibrary.Trigonometry.GetCos(cathet, hypotenuse);

            //Assert
            Assert.AreEqual(sin, result);
        }

        [TestMethod]
        public void GetCosTest5()
        {
            //Arrange
            double cathet = 10;
            double hypotenuse = 2;
            double sin = 5;

            //Act
            double result = MathLibrary.Trigonometry.GetCos(cathet, hypotenuse);

            //Assert
            Assert.AreEqual(sin, result);
        }

        [TestMethod]
        public void GetTangTest1()
        {
            //Arrange
            double oppositeCathet = 3;
            double adjacentCathet = 1;

            double tang = 3;

            //Act

            double methodRes = MathLibrary.Trigonometry.GetTang(oppositeCathet, adjacentCathet);

            //Assert

            Assert.AreEqual(tang, methodRes);
        }

        [TestMethod]
        public void GetTangTest2()
        {
            //Arrange
            double oppositeCathet = 6;
            double adjacentCathet = 2;

            double tang = 3;

            //Act

            double methodRes = MathLibrary.Trigonometry.GetTang(oppositeCathet, adjacentCathet);

            //Assert

            Assert.AreEqual(tang, methodRes);
        }

        [TestMethod]
        public void GetTangTest3()
        {
            //Arrange
            double oppositeCathet = 2;
            double adjacentCathet = 4;

            double tang = 0.5;

            //Act

            double methodRes = MathLibrary.Trigonometry.GetTang(oppositeCathet, adjacentCathet);

            //Assert

            Assert.AreEqual(tang, methodRes);
        }

        [TestMethod]
        public void GetTangTest4()
        {
            //Arrange
            double oppositeCathet = 8;
            double adjacentCathet = 2;

            double tang = 4;

            //Act

            double methodRes = MathLibrary.Trigonometry.GetTang(oppositeCathet, adjacentCathet);

            //Assert

            Assert.AreEqual(tang, methodRes);
        }

        [TestMethod]
        public void GetTangTest5()
        {
            //Arrange
            double oppositeCathet = 9;
            double adjacentCathet = 2;

            double tang = 4.5;

            //Act

            double methodRes = MathLibrary.Trigonometry.GetTang(oppositeCathet, adjacentCathet);

            //Assert

            Assert.AreEqual(tang, methodRes);
        }

        [TestMethod]
        public void GetCotangTest1()
        {
            //Arrange
            double oppositeCathet = 2;
            double adjacentCathet = 4;

            double tang = 2;

            //Act

            double methodRes = MathLibrary.Trigonometry.GetCotang(oppositeCathet, adjacentCathet);

            //Assert

            Assert.AreEqual(tang, methodRes);
        }

        [TestMethod]
        public void GetCotangTest2()
        {
            //Arrange
            double oppositeCathet = 6;
            double adjacentCathet = 36;

            double tang = 6;

            //Act

            double methodRes = MathLibrary.Trigonometry.GetCotang(oppositeCathet, adjacentCathet);

            //Assert

            Assert.AreEqual(tang, methodRes);
        }

        [TestMethod]
        public void GetCotangTest3()
        {
            //Arrange
            double oppositeCathet = 5;
            double adjacentCathet = 15;

            double tang = 3;

            //Act

            double methodRes = MathLibrary.Trigonometry.GetCotang(oppositeCathet, adjacentCathet);

            //Assert

            Assert.AreEqual(tang, methodRes);
        }

        [TestMethod]
        public void GetCotangTest4()
        {
            //Arrange
            double oppositeCathet = 10;
            double adjacentCathet = 100;

            double tang = 10;

            //Act

            double methodRes = MathLibrary.Trigonometry.GetCotang(oppositeCathet, adjacentCathet);

            //Assert

            Assert.AreEqual(tang, methodRes);
        }

        [TestMethod]
        public void GetCotangTest5()
        {
            //Arrange
            double oppositeCathet = 6;
            double adjacentCathet = 3;

            double tang = 0.5;

            //Act

            double methodRes = MathLibrary.Trigonometry.GetCotang(oppositeCathet, adjacentCathet);

            //Assert

            Assert.AreEqual(tang, methodRes);
        }

        #endregion

        #region Trigonometry

        #endregion
    }
}