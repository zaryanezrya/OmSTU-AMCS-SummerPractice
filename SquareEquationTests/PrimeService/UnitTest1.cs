using Xunit;
using SquareEquationLib;

namespace SquareEquationLib.Tests;

public class SquareEquationLib_isUnite
{
    [Fact]
    public void TwoRoots()
    {
        double[] expected = new double[] { 9, 4 };
        double[] actual = SquareEquation.Solve(1, -13, 36);

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void OneRoot()
    {
        double[] expected = new double[] { -2 };
        double[] actual = SquareEquation.Solve(1, 4, 4);

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Nothing()
    {
        double[] expected = new double[] { };
        double[] actual = SquareEquation.Solve(4, 2, 8);

        Assert.Equal(expected, actual);
    }



    [Fact]
    public void ThrowsArgumentException()
    {
        Assert.Throws<System.ArgumentException>(() => SquareEquation.Solve(0, 2, 3));
    }

    [Theory]
    [InlineData(double.NaN, 2, 3)]
    [InlineData(1, double.PositiveInfinity, 3)]
    [InlineData(1, 2, double.NegativeInfinity)]
    public void WrongCoefficients(double a, double b, double c)
    {
        Assert.Throws<System.ArgumentException>(() => SquareEquation.Solve(a, b, c));
    }
}