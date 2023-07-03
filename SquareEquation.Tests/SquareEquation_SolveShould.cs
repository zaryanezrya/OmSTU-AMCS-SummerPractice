using Xunit;
using SquareEquationLib;

namespace Solve.UnitTests
{
    public class SquareEquation_SolveShould
    {
        [Fact]
        public void Solve_1_2_n3_Return_n3_1()
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

        [Fact]

        public void Solve_1_n2_1_Return_1()
        {
            double[] expected = { 1 };
            double[] actual = SquareEquation.Solve(1, -2, 1);
            Assert.Equal(expected, actual);
        }

        [Fact]
        
        public void Solve_1_1_2_Return_EmptArr()
        {
            double[] expected = {};
            double[] actual = SquareEquation.Solve(1, 1, 2);
            Assert.Equal(expected, actual);
        }
    }
}