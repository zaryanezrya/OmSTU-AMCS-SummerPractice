﻿namespace SquareEquationLib;

public class SquareEquation
{
    public static double[] Solve(double a, double b, double c)
    {        
        const double TOLERANCE = 0.001;

        if (a < TOLERANCE)
            throw new System.ArgumentException();

        foreach (double x in new double[] {a, b, c})
        {
            if (double.IsSubnormal(x))
                throw new System.ArgumentException();
        }

        double D = b*b - 4*a*c;        
        if (Math.Sign(D) < 0 && !(Math.Abs(D) < TOLERANCE))
            return new double[0];

        double x1 = -(b + Math.Sign(b)*Math.Sqrt(D))/2;
        double x2 = c/x1;

        if (D < TOLERANCE)
            return new double[] {x1};
        
        return new double[] {x1, x2};

        
    }
}
