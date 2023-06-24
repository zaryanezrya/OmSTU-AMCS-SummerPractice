using System;

namespace SquareEquationLib;

public class SquareEquation
{
    public static double[] Solve(double a, double b, double c)
    {
        double positive = double.PositiveInfinity;
        double negative = double.NegativeInfinity;
        double eps = double.Epsilon;
        double NaN = double.NaN;
        if (a==0)
        {
            throw new System.ArgumentException();
        }
        else if ((a==positive) || (a==negative) || (a==NaN))
        {
            throw new ArgumentException();
        }
        else if ((b==positive) || (b==negative) || (b==NaN))
        {
            throw new ArgumentException();
        }
        else if ((c==positive) || (c==negative) || (c==NaN))
        {
            throw new ArgumentException();
        }
        else
        {
            double D = Math.Pow(b,2)-4*a*c;
            if((D>0) /*|| ((Math.Abs(D)<eps) && (D!=0))*/)
            {
                double x1 = -(b + Math.Sign(b)*Math.Sqrt(D))/2;
                double x2 = c/x1;
                double[] ans = new double[2]{x1,x2};
                return ans;
            }
            else if(D==0)
            {
                double x1 = -(b + Math.Sign(b)*Math.Sqrt(D))/2;
                double[] ans = new double[1]{x1};
                return ans;
            }
            else
            {
                double[] ans = new double[]{};
                return ans;
            }
            
        }
    }
}
