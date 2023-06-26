namespace SquareEquationLib;

public class SquareEquation
{
    public static double[] Solve(double a, double b, double c)
    {
        double d;
        double[] roots = new double[0];
        d = b * b - 4 * c;
        if (a == 0)
        {
            throw new NotImplementedException();
        }
        if ( double.IsNaN(a) || double.IsNaN(b) || double.IsNaN(c) ||
            double.IsPositiveInfinity(a) || double.IsPositiveInfinity(b) || double.IsPositiveInfinity(c) ||
            double.IsNegativeInfinity(a) || double.IsNegativeInfinity(b) || double.IsNegativeInfinity(c))
        {
            throw new ArgumentException();
        }
        if (Math.Abs(d) < 1e-10)
        {
            double x1 = (-b + Math.Sqrt(d)) / 2;
            roots = new double[1];
            roots[0] = x1;
            return roots;
        }
        else if (d < 0)
        {
            return roots;
        }
        else
        {
            double x1 = (-b + Math.Sqrt(d)) / 2;
            double x2 = (-b - Math.Sqrt(d)) / 2;
            roots = new double[2];
            roots[0] = x1; roots[1] = x2;
            return roots;

        }
       
    }

}
