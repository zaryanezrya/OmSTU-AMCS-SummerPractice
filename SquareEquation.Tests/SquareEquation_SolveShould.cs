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
            double[] expected = { -3d, 1d };
            double[] actual = _squareEquation.Solve(1d, 2d, -3d);
            Assert.Equal(expected, actual);
        }

        [Fact]
        
        public void Solve_AEqv0_ReturnArgExc()
        {
            Action act = () => _squareEquation.Solve(1e-7, 1d, 1d);
            Assert.Throws<System.ArgumentException>(act);
        }

        [Theory]

        [InlineData(double.NaN, 1d, 1d)]
        [InlineData(1d, double.NaN, 1d)]
        [InlineData(1d, 1d, double.NaN)]

        [InlineData(double.PositiveInfinity, 1d, 1d)]
        [InlineData(1d, double.PositiveInfinity, 1d)]
        [InlineData(1d, 1d, double.PositiveInfinity)]

        [InlineData(double.NegativeInfinity, 1d, 1d)]
        [InlineData(1d, double.NegativeInfinity, 1d)]
        [InlineData(1d, 1d, double.NegativeInfinity)]
        
        public void Solve_NanOrInf_ReturnArgExc(double a, double b, double c)
        {
            Action act = () => _squareEquation.Solve(a, b, c);
            Assert.Throws<System.ArgumentException>(act);
        }

        [Theory]
        [InlineData(1d, -2d, 1d)]

        public void Solve_ReturnOneRoot(double a, double b, double c)
        {
            double[] expected = { 1d };
            double[] actual = _squareEquation.Solve(a, b, c);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1d, 1d, 2d)]
        
        public void Solve_ReturnNoRoots(double a, double b, double c)
        {
            double[] expected = {};
            double[] actual = _squareEquation.Solve(a, b, c);
            Assert.Equal(expected, actual);
        }
    }
}