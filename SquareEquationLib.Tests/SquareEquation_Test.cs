using Xunit;
using SquareEquationLib;

namespace SquareEquationLib.UnitTests
{
    public class SquareEquationLib_Test
    {
        [Fact]
        public void AIs0Test()
        {
            double a = 0;
            double b = 0;
            double c = 0;

            bool result = false;

            try
            {
                var uselessVariable = SquareEquation.Solve(a, b, c);
            }
            catch (ArgumentException) 
            {
                return;
            }
            catch {}

            Assert.True(result, "Expected ArgumentException");
        }
        [Fact]
        public void InnormalArgumentTest()
        {
            var values = new double[] {double.NaN, double.PositiveInfinity, double.NegativeInfinity};
            double[] methodResult;
            var result = false;
            try 
            {
                foreach(double a in values)
                {
                    foreach(double b in values)
                    {
                        foreach(double c in values)
                        {
                            methodResult = SquareEquation.Solve(a, b, c);
                        }
                    }
                }
            }
            catch (ArgumentException)
            {
                return;
            }
            catch {}
            Assert.True(result, "Expected ArgumentException");
        }
        [Theory]
        [InlineData(1,1,0.250000000025)]
        [InlineData(0.5,1,0.50000000005)]
        public void DiscriminantCloseToZero(double a, double b, double c)
        {
            double[] methodResult;
            methodResult = SquareEquation.Solve(a,b,c);
            bool result = methodResult.Length != 0;
            
            Assert.True(result, "Excpected real roots");
        }

        [Theory]
        [InlineData(1, 0, 1)]
        [InlineData(10, 2, 10)]
        public void NoRealRoots(double a, double b, double c)
        {
            double[] methodResult;
            methodResult = SquareEquation.Solve(a,b,c);
            bool result = methodResult.Length == 0;

            Assert.True(result, "Excpected no real roots");
        }
        [Theory]
        [InlineData(1,0,0)]
        [InlineData(1,4,4)]
        public void OneRealRoot(double a, double b, double c)
        {
            double[] methodResult;
            methodResult = SquareEquation.Solve(a,b,c);
            bool result = methodResult.Length == 1;

            Assert.True(result, "Excepected 1 real root");
        }
        [Theory]
        [InlineData(1,0,-1)]
        [InlineData(1,5,6)]
        public void TwoRealRoots(double a, double b, double c)
        {
            double[] methodResult;
            methodResult = SquareEquation.Solve(a,b,c);
            bool resutl = methodResult.Length == 2;

            Assert.True(resutl, "Expected 2 real roots");
        }
        [Theory]
        [InlineData(1, 0, 1, new double[0])]
        [InlineData(1, 0, 0, new double[] {0})]
        [InlineData(1, 5, 6, new double[] {-2, -3})]
        public void RootCorectness(double a, double b, double c, double[] excpectedResult)
        {
            const double TOLERANCE = 0.000001;
            
            double[] methodResult;
            methodResult = SquareEquation.Solve(a,b,c);
            bool result = true;

            if (methodResult.Length != excpectedResult.Length)
            {
                result = false;
            }
            else 
            {
                for (int i = 0; i < methodResult.Length; i++)
                {
                    if (Math.Abs(methodResult[i] - excpectedResult[i]) > TOLERANCE)
                    {
                        break;
                    }
                }
                result = true;
            }

            Assert.True(result, "Incorrect answer");
        }

    }
}
