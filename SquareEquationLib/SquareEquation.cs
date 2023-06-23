namespace SquareEquationLib;

public class SquareEquation
{
    public static double[] Solve(double a, double b, double c)
    {
        int kvadr(double b, double c, double *x1, double *x2)
        {
            double d;
            d=b*b-4*c;
            if (d<0) return 0;
            *x1=(-b+sqrt(d))/2;
            *x2=(-b-sqrt(d))/2;
            x1=-(b+sign(b)*sqrt(d))/2;
            x2=c/x1
            return 1;
        }
        throw new NotImplementedException();
    }
}
