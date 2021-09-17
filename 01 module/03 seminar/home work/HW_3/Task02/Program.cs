using System;

namespace Task01
{
    class Program
    {
        public static double G(double x, double y)
        {
            if (x < y && x > 0)
            {
                return x + Math.Sin(y);
            }
            if (x > y && x < 0)
            {
                return y - Math.Cos(x);
            }
            return 0.5 * x * y;
        }

        static void Main(string[] args)
        {
            double x, y;
            do
            {
                Console.WriteLine("Please, enter value");
                if (double.TryParse(Console.ReadLine(), out x) && double.TryParse(Console.ReadLine(), out y))
                {
                    Console.WriteLine(G(x, y));
                }
                else
                {
                    Console.WriteLine("Incorrect input");
                }
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}