using Xunit;
using SquareEquationLib;


namespace Prime.UnitTests.Services
{
    public class PrimeService_IsPrimeShould
    {
        [Fact]
        public void Test1()
        {
            var squareEquation = new SquareEquation();
            double[] ans = squareEquation.Solve(1,3,-4);
            double[] r_ans = new double[2]{-4,1};

            Assert.Equal(r_ans, ans);
        }

        [Fact]
        public void Test2()
        {
            var squareEquation = new SquareEquation();
            double[] ans = squareEquation.Solve(1,-4,4);
            double[] r_ans = new double[1]{2};

            Assert.Equal(r_ans, ans);
        }

        [Fact]
        public void Test3()
        {
            var squareEquation = new SquareEquation();
            double[] ans = squareEquation.Solve(1,-5,9);
            double[] r_ans = new double[]{};

            Assert.Equal(r_ans, ans);
        }

        [Fact]
        public void Test4()
        {
            var squareEquation = new SquareEquation();
            Assert.Throws<ArgumentException>(() => squareEquation.Solve(0,-5,9));
        }

        [Fact]
        public void Test5()
        {
            var squareEquation = new SquareEquation();
            Assert.Throws<ArgumentException>(() => squareEquation.Solve(double.PositiveInfinity,-5,9));
        }
        [Fact]
        public void Test6()
        {
            var squareEquation = new SquareEquation();
            Assert.Throws<ArgumentException>(() => squareEquation.Solve(1,double.NaN,4));
        }

        [Fact]
        public void Test7()
        {
            var squareEquation = new SquareEquation();
            Assert.Throws<ArgumentException>(() => squareEquation.Solve(1,-4,double.NegativeInfinity));
        }
    }
}