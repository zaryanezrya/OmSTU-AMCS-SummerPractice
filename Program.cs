namespace SquareEquation
{
    class SquareEquation
    {
        public double a;
        public double b;
        public double c;
        public SquareEquation(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public double[] Solve()
        {
            double NaN = 0.0/0.0;
            double NegativeInfinity = double.NegativeInfinity;
            double PositiveInfinity = double.PositiveInfinity;
            
            if ((a==PositiveInfinity) || (a==NegativeInfinity) || (a==NaN) || (a==0) )
            {
                throw new System.ArgumentException();
            }
            else if ((b==PositiveInfinity) || (b==NegativeInfinity) || (b==NaN) )
            {
                throw new System.ArgumentException();
            }
            else if ((c==PositiveInfinity) || (c==NegativeInfinity) || (c==NaN) )
            {
                throw new System.ArgumentException();
            }
            else
            {
                double x1 = -(b + Math.Sign(b)*Math.Sqrt(Math.Pow(b,2)-4*a*c))/2;
                double x2 = c/x1;
                double[] ans = new double[2]{x1,x2};
                return ans;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            SquareEquation sq = new SquareEquation(1, 3, -4);
            double[] ans = sq.Solve();
            foreach (double x in ans)
            {
                Console.WriteLine("Ответ: " + x);
            }   
        }
    }
}