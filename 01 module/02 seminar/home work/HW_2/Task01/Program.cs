using System;

namespace Task01
{
    class Program
    {
        public static double Horner_method(double x) 
        {
            /*
            12x^4 + 9x^3 - 3x^2 + 2x - 4 =
            = (12x^3 + 9x^2 - 3x + 2) * x - 4 =
            = ((12x^2 + 9x - 3) * x + 2) * x - 4 =
            = (((12x + 9) * x - 3) * x + 2) * x - 4
            */
            return (((12 * x + 9) * x - 3) * x + 2) * x - 4;
        }

        static void Main(string[] args)
        {
            double x;
            do
            {
                Console.WriteLine("Please, enter value");
                if (double.TryParse(Console.ReadLine(), out x))
                {
                    Console.WriteLine(Horner_method(x));
                }
                else
                {
                    Console.WriteLine("Incorrect input");
                }
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
