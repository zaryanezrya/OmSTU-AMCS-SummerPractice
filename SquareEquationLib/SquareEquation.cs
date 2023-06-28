namespace SquareEquationLib;

public class SquareEquation
{
    public static double[] Solve(double a, double b, double c)
    {
        double eps = Math.Pow(10,-16);
        if (Math.Abs(a) < eps) throw new System.ArgumentException();
        foreach(var x in new double[] {a,b,c})
        if (System.Double.IsNaN(x) || System.Double.IsInfinity(x)) throw new System.ArgumentException(); 

        double D = Math.Pow(b,2) - 4*a*c;
        if (Math.Abs(D) < eps ) return new double[] {-(b + Math.Sign(b)*Math.Sqrt(D))/(2*a)}; 
        if (D <= -eps) return new double[0];
        double x1 = -(b + Math.Sign(b)*Math.Sqrt(D))/(2*a), x2 = c/x1;
        return new double[] {x1,x2}; 
    }
}
