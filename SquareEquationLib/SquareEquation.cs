namespace SquareEquationLib;

public class SquareEquation
{
    public static double[] Solve(double a, double b, double c)
    {
        double[] answer = new double[0];
        double x1;
        double x2;

        if (Double.IsPositiveInfinity(a) || Double.IsNegativeInfinity(a) || Math.Abs(a) < Double.Epsilon || Double.IsNaN(a))
        {
            throw new System.ArgumentException();
        }
        if (Double.IsPositiveInfinity(b) || Double.IsNegativeInfinity(b) || Double.IsNaN(b))
        {
            throw new System.ArgumentException();
        }
        if (Double.IsPositiveInfinity(c) || Double.IsNegativeInfinity(c) || Double.IsNaN(c))
        {
            throw new System.ArgumentException();
        }

        double D = (b * b) - (4.0 * a * c);
        
        if (D > -Double.Epsilon && D < Double.Epsilon)
        {
            answer = new double[1];

            D = 0;

            x1 = -(b + Math.Sign(b) * Math.Sqrt(D)) / 2 ;

            answer[0] = x1;                  
        }
        if(D >= Double.Epsilon)
        {
            answer = new double[2];
            
            x1 = -(b + Math.Sign(b) * Math.Sqrt(D)) / 2 ;
            x2 = c / x1;

            answer[0] = x1;
            answer[1] = x2;
        }

        return answer;
    }
}


