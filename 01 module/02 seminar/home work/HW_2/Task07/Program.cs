using System;

namespace Task01
{
    class Program
    {
        public static (double, int) Int_fract(double x)
        {
            return (x - (int)x, (int)x);
        }

        public static (double, double) Square_sqrt(double x)
        {
            return (x * x, Math.Sqrt(x));
        }

        static void Main(string[] args)
        {
            double x;
            do
            {
                Console.WriteLine("Please, enter value");
                if (double.TryParse(Console.ReadLine(), out x))
                {
                    (double, int) ans1 = Int_fract(x);
                    (double, double) ans2 = Square_sqrt(x);
                    Console.WriteLine(ans1.Item1);
                    Console.WriteLine(ans1.Item2);
                    Console.WriteLine(ans2.Item1);
                    Console.WriteLine(ans2.Item2);
                }
                else
                {
                    Console.WriteLine("Incorrect input");
                }
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
