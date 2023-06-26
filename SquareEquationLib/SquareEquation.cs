namespace SquareEquationLib;
public class SquareEquation
{
    public static double[] Solve(double a, double b, double c)
    {
        double Epsilon=1e-9;
        if (-Epsilon < a && a < Epsilon) throw new ArgumentException();
        if ( new[] { a, b, c }.Any(double.IsNaN) || new[] { a, b, c }.Any(double.IsInfinity))
            throw new ArgumentException();
        double D=b * b - 4 *a*c;
        double[] Result1 = new double[] { };
        if (D <= -Epsilon) return Result1;
        else if (-Epsilon < D & D < Epsilon)
        { 
            double[] Result2 = new double[1];
            Result2[0] = -(b) / 2*a;
            return Result2;
        }
        else
        {
            double[] Result3 = new double[2];
            Result3[0] = -(b + Math.Sign(b) * Math.Sqrt(D)) / 2;
            Result3[1] = c / Result3[0];
            return Result3;
        }
    }
}
