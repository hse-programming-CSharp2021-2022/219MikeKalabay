using System;

namespace Task01
{
    class Program
    {
        public static double f(double x)
        {
            return x * x;
        }

        static void Main(string[] args)
        {
            double a, b, delta;
            if (double.TryParse(Console.ReadLine(), out a) && double.TryParse(Console.ReadLine(), out b) && double.TryParse(Console.ReadLine(), out delta))
            {
                double ans = 0;
                double now = a + delta;
                double prev = a;
                while (now < b)
                {
                    ans += delta * (f(now) + f(prev)) / 2;
                    prev = now;
                    now += delta;
                }
                now = b;
                double h = now - prev;
                ans += h * (f(now) + f(prev)) / 2;
                Console.WriteLine(ans);
            }
        }
    }
}