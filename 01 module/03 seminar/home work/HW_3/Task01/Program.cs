using System;

namespace Task01
{
    class Program
    {
        public static double Cross_product((double, double) v1, (double, double) v2)
        {
            return v1.Item1 * v2.Item2 - v2.Item1 * v1.Item2;
        }

        public static double Dot_product((double, double) v1, (double, double) v2)
        {
            return v1.Item1 * v2.Item1 + v1.Item2 * v2.Item2;
        }

        public static bool G(double x, double y)
        {
            double len = Math.Sqrt(x * x + y * y);
            if (len == 0)
            {
                return true;
            }
            (double, double) vect1 = (x / len, y / len);
            (double, double) vect2 = (1, 0);
            return len <= 2 && Cross_product(vect2, vect1) < Math.Sqrt(2) / 2 && Dot_product(vect1, vect2) >= 0;
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