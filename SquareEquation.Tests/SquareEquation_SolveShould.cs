using Xunit;
using SquareEquationLib;

namespace Solve.UnitTests
{
    public class SquareEquation_SolveShould
    {
        private SquareEquation _squareEquation;
        public SquareEquation_SolveShould()
        {
            _squareEquation = new SquareEquation();
        }

        [Fact]
        
        public void Solve_ReturnTwoRoots()
        {
            double[] expected = { -3, 1 };
            double[] actual = SquareEquation.Solve(1, 2, -3);
            Assert.Equal(expected, actual);
        }

        [Fact]
        
        public void Solve_AEqv0_ReturnArgExc()
        {
            Action act = () => SquareEquation.Solve(1e-10, 1, 1);
            Assert.Throws<System.ArgumentException>(act);
        }

        [Theory]

        [InlineData(double.NaN, 1, 1)]
        [InlineData(1, double.NaN, 1)]
        [InlineData(1, 1, double.NaN)]

        [InlineData(double.PositiveInfinity, 1, 1)]
        [InlineData(1, double.PositiveInfinity, 1)]
        [InlineData(1, 1, double.PositiveInfinity)]

        [InlineData(double.NegativeInfinity, 1, 1)]
        [InlineData(1, double.NegativeInfinity, 1)]
        [InlineData(1, 1, double.NegativeInfinity)]
        
        public void Solve_NanOrInf_ReturnArgExc(double a, double b, double c)
        {
            Action act = () => SquareEquation.Solve(a, b, c);
            Assert.Throws<System.ArgumentException>(act);
        }

        [Theory]
        [InlineData(1, -2, 1)]

        public void Solve_ReturnOneRoot(double a, double b, double c)
        {
            double[] expected = { 1 };
            double[] actual = SquareEquation.Solve(a, b, c);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1, 1, 2)]
        
        public void Solve_ReturnNoRoots(double a, double b, double c)
        {
            double[] expected = {};
            double[] actual = SquareEquation.Solve(a, b, c);
            Assert.Equal(expected, actual);
        }
    }
}