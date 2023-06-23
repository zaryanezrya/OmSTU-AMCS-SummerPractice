namespace SquareEquationLib;

public class SquareEquation
{
    public static double[] Solve(double a, double b, double c)
    {
        double NaN = 0.0/0.0;
        double NegativeInfinity = double.NegativeInfinity;
        double PositiveInfinity = double.PositiveInfinity;
            
        if ((a==PositiveInfinity) || (a==NegativeInfinity) || (a==NaN) || (a==0) )
        {
            throw new System.ArgumentException();
        }
        else if ((b==PositiveInfinity) || (b==NegativeInfinity) || (b==NaN) )
        {
            throw new System.ArgumentException();
        }
        else if ((c==PositiveInfinity) || (c==NegativeInfinity) || (c==NaN) )
        {
            throw new System.ArgumentException();
        }
        else
        {
            double x1 = -(b + Math.Sign(b)*Math.Sqrt(Math.Pow(b,2)-4*a*c))/2;
            double x2 = c/x1;
            double[] ans = new double[2]{x1,x2};
            return ans;
        }
    }
}