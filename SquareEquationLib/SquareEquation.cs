namespace SquareEquationLib;
public class SquareEquation
{
    public static double[] Solve(double a, double b, double c)
    {
        double epsilon=1e-9;
        double D=b * b - 4 *a*c;
        double[] Result1 = new double[] { };

        if (-epsilon < a && a < epsilon) 
        {
            throw new ArgumentException("Ошибочка вышла");
        }
        if ((-epsilon < a) && (a < epsilon) || (double.IsInfinity(a)) || (double.IsInfinity(b)) || (double.IsInfinity(c)) || (double.IsNaN(a)) || (double.IsNaN(b)) || (double.IsNaN(c))) 
            throw new ArgumentException("Ошибочка вышла");
        
        if (D <= -epsilon) return Result1;
        else if (-epsilon < D & D < epsilon)
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