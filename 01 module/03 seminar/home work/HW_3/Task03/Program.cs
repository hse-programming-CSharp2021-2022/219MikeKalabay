using System;

namespace Task01
{
    class Program
    {
        public static double G(double x)
        {
            if (x <= 0.5)
            {
                return 1;
            }
            return Math.Sin(Math.PI * (x - 1) / 2);
        }

        static void Main(string[] args)
        {
            double x;
            do
            {
                Console.WriteLine("Please, enter value");
                if (double.TryParse(Console.ReadLine(), out x))
                {
                    Console.WriteLine(G(x));
                }
                else
                {
                    Console.WriteLine("Incorrect input");
                }
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}