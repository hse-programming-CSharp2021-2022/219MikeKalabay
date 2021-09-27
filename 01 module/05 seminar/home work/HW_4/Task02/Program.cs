using System;

namespace Task01
{
    class Program
    {
        public static double F1(double x)
        {
            double s = 0;
            double prev = -1;
            int i = 0;
            double p = 3;
            double now = x * x;
            while (s != prev)
            {
                prev = s;
                if (i % 2 == 0)
                {
                    s += now;
                }
                else
                {
                    s -= now;
                }
                now = now * x * x * 2 * 2 / p / (p + 1);
                i += 1;
                p += 2;
            }
            return s;
        }

        public static double F2(double x)
        {
            double s = 0;
            double prev = -1;    
            double p = 1;
            double now = 1;
            while (s != prev)
            {
                prev = s;
                s += now;
                now *= x / p;
                p += 1;
            }
            return s;
        }

        static void Main(string[] args)
        {
            double x;
            do
            {
                Console.WriteLine("Please, enter value");
                if (double.TryParse(Console.ReadLine(), out x))
                {
                    Console.WriteLine(F1(x));
                    Console.WriteLine(F2(x));
                }
                else
                {
                    Console.WriteLine("Incorrect input");
                }
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}