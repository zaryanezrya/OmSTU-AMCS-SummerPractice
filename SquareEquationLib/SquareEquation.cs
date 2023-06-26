namespace SquareEquationLib;

public class SquareEquation
{
    public static double[] Solve(double a, double b, double c)
    {
        double[] Result = new double[2];
        double D,x1,x2;
        D=(b*b)-(4*a*c);
        double epsilon=1e-9;

        if ((-epsilon<a)&&(a<epsilon)) 
            throw new System.ArgumentException(); 
        if ((Double.IsNaN(a)) || (Double.IsNegativeInfinity(a)) || (Double.IsPositiveInfinity(a))||(Math.Abs(a)==0) ) 
            throw new ArgumentException();
        if ((Double.IsNaN(b)) || (Double.IsNegativeInfinity(b)) || Double.IsPositiveInfinity(b)) 
            throw new ArgumentException();
        if ((Double.IsNaN(c)) || (Double.IsNegativeInfinity(c)) || Double.IsPositiveInfinity(c)) 
            throw new ArgumentException();
           
        
        if (D<=-epsilon){
           Result = new double[0];
        }
        else if ((-epsilon<D) && (D<epsilon)){
            x1=-b/(2*a);
            Result = new double[] {x1};
        }
        else{
            x1 = (2*c)/-(b+Math.Sign(b)*Math.Sqrt(D));
            x2 = c / (a*x1);
            Result = new double[] { x1, x2 };
        }
        return Result;
    }
}