using System;

namespace Task01
{
    class Program
    {
        public static double Total(double k, double r, uint n)
        {
            if (n == 0)
            {
                return k;
            }

            return (1 + r) * Total(k, r, n - 1);
        }

        public static double Total2(double k, double r, uint n)
        {
            for (int i = 0; i < n; ++i)
            {
                k *= (1 + r);
            }

            return k;
        }

        static void Main(string[] args)
        {
            double k, r;
            uint n;
            if (double.TryParse(Console.ReadLine(), out k) && double.TryParse(Console.ReadLine(), out r) && uint.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine(Total(k, r, n));
                Console.WriteLine(Total2(k, r, n));
            }
        }
    }
}