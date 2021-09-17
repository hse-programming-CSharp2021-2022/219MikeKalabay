using System;

namespace Task01
{
    class Program
    {
        public static void get_budget(double k, int r)
        {
            double ans = k * r / 100;
            Console.WriteLine(ans.ToString("C", new System.Globalization.CultureInfo("en-US")));
        }

        static void Main(string[] args)
        {
            double k;
            int r;
            do
            {
                Console.WriteLine("Please, enter value");
                if (double.TryParse(Console.ReadLine(), out k) && int.TryParse(Console.ReadLine(), out r))
                {
                    get_budget(k, r);
                }
                else
                {
                    Console.WriteLine("Incorrect input");
                }
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
