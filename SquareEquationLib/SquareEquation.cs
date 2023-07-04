namespace SquareEquationLib;

public class SquareEquation
{
    public static double[] Solve(double a, double b, double c)
    {
        const double e = 0.0000000000001;

        if (Math.Abs(a) < e) throw new System.ArgumentException();
        foreach(double x in new double[] {a, b, c}){
            if (double.IsNaN(x) | double.IsInfinity(x)) throw new System.ArgumentException();
        }

        double D = b*b - 4*a*c;

        double x1;
        if(b == 0) x1 = -(b + Math.Sqrt(D))/2;
        else x1 = -(b + Math.Sign(b)*Math.Sqrt(D))/2;
        double x2 = c/x1;

        if (Math.Abs(D) < e){
            return new double[] {x1};
        }

        if(D < 0) return new double[0];

        return new double[] {x1, x2};
    }
}