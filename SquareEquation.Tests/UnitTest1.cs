using Xunit;
using SquareEquationLib;

namespace SquareEquationLib.Tests;

public class SquareEquationLib_isUnite
{
    [Fact]
    public void TwoRoots()
    {
        double[] expected = new double[] { 1, -4 };
        double[] actual = SquareEquation.Solve(1, 3, -4);

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void OneRoot()
    {
        double[] expected = new double[] { -1 };
        double[] actual = SquareEquation.Solve(2, 4, 2);

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Nothing()
    {
        double[] expected = new double[] { };
        double[] actual = SquareEquation.Solve(2, 4, 3);

        Assert.Equal(expected, actual);
    }



    [Fact]
    public void ThrowsArgumentException()
    {
        Assert.Throws<System.ArgumentException>(() => SquareEquation.Solve(0, 1, 2));
    }

    [Theory]
    [InlineData(4, double.NaN, 1)]
    [InlineData(4, 5, double.NegativeInfinity)]
    [InlineData(double.PositiveInfinity, 1, 2)]
    public void WrongCoefficients(double a, double b, double c)
    {
        Assert.Throws<System.ArgumentException>(() => SquareEquation.Solve(a, b, c));
    }
}