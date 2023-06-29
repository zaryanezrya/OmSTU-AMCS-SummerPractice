using SquareEquationLib;

namespace XUnit.Coverlet.MSBuild;

public class UnitTest1
{
    const double eps = 1e-9;

    [Fact]
    public void Is_A_0()
    {
        Assert.Throws<System.ArgumentException>(() => SquareEquation.Solve(0,1,1));
    }

    [Fact]
    public void Is_A_NaN()
    {
        Assert.Throws<System.ArgumentException>(() => SquareEquation.Solve(double.NaN,1,1));
    }
    [Fact]
    public void Is_B_NaN()
    {
        Assert.Throws<System.ArgumentException>(() => SquareEquation.Solve(1,double.NaN,1));
    }
    [Fact]
    public void Is_C_NaN()
    {
        Assert.Throws<System.ArgumentException>(() => SquareEquation.Solve(1,1,double.NaN));
    }

    [Theory]
    [InlineData(-eps/2, 1, 1)]
    [InlineData(eps/2, 2, 2)]
    [InlineData(0, 1, 1)]
    public void AisZero(double a, double b, double c)
    {
        Assert.Throws<System.ArgumentException>(() => SquareEquation.Solve(a,b,c));
    }

    [Theory]
    [InlineData(1, 2, 1)]
    [InlineData(1, 0, 0)]
    public void One_Solution(double a, double b, double c)
    {
        double x = SquareEquationLib.SquareEquation.Solve(a,b,c)[0];
        Assert.Equal(0, Math.Abs(a*Math.Pow(x,2)+b*x+c), eps);
    }

    [Theory]
    [InlineData(-4, 5, 15)]
    [InlineData(3, 6, -15)]
    [InlineData(1, -5, 1)]
    public void Two_Solution(double a, double b, double c)
    {
        double[] array = SquareEquationLib.SquareEquation.Solve(a,b,c);
        foreach(double x in array)
        {
            Assert.Equal(0, Math.Abs(a*Math.Pow(x,2)+b*x+c), eps);
        } 
    }
}