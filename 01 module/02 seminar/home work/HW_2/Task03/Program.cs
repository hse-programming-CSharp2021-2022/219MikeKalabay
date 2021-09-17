using System;

namespace Task01
{
    class Program
    {
        public static void Solve(double a, double b, double c)
        {
            double d = b * b - 4 * a * c;
            Console.WriteLine(a == 0 ? (b == 0 ? (c == 0 ? "any x = solution" : "No solutions") : -c / b) : (d == 0 ? -b / (2 * a) : (d > 0 ? Convert.ToString((-b + Math.Sqrt(d)) / (2 * a)) + " " + Convert.ToString((-b - Math.Sqrt(d)) / (2 * a)) : "No solutions in R")));
        }

        static void Main(string[] args)
        {
            double A, B, C;
            do
            {
                Console.WriteLine("Please, enter value");
                if (double.TryParse(Console.ReadLine(), out A) && double.TryParse(Console.ReadLine(), out B) && double.TryParse(Console.ReadLine(), out C))
                {
                    Solve(A, B, C);
                }
                else
                {
                    Console.WriteLine("Incorrect input");
                }
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
