using System;

namespace Task01
{
    class Program
    {
        public static void Check(double a, double b, double c)
        {
            int cnt = 0;
            cnt += a + b > c ? 1 : 0;
            cnt += a + c > b ? 1 : 0;
            cnt += c + b > a ? 1 : 0;
            Console.WriteLine(cnt == 3 ? "True" : "False");
        }

        static void Main(string[] args)
        {
            double A, B, C;
            do
            {
                Console.WriteLine("Please, enter value");
                if (double.TryParse(Console.ReadLine(), out A) && double.TryParse(Console.ReadLine(), out B) && double.TryParse(Console.ReadLine(), out C))
                {
                    Check(A, B, C);
                }
                else
                {
                    Console.WriteLine("Incorrect input");
                }
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
