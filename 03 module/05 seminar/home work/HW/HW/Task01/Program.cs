using System;

namespace Task01
{
    interface IFunction
    {
        double Function(double x);
    }

    delegate double calculate(double x);

    class F : IFunction
    {
        public calculate now { get; set; }

        public F(calculate calc)
        {
            now = calc;
        }

        public double Function(double x)
        {
            return now(x);
        }
    }

    class G
    {
        F f1;
        F f2;

        public G(F f1, F f2)
        {
            this.f1 = f1;
            this.f2 = f2;
        }

        public double GF(double x)
        {
            return f1.Function(f2.Function(x));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            calculate f1 = (double x) => (x * x - 4);
            calculate f2 = (double x) => (Math.Sin(x));
            G g = new G(new F(f2), new F(f1));
            double i = 0;
            while (i < Math.PI)
            {
                Console.WriteLine($"{g.GF(i):F4}");
                i += Math.PI / 16;
            }
        }
    }
}