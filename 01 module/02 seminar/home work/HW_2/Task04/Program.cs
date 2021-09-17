using System;

namespace Task01
{
    class Program
    {
        public static bool Check_number(int x)
        {
            int cnt = 0;
            while (x != 0)
            {
                x /= 10;
                cnt += 1;
            }
            return (cnt == 4);
        }

        public static void Reverse(int x)
        {
            for (int i = 0; i < 4; ++i)
            {
                Console.Write(x % 10);
                x /= 10;
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            int x;
            do
            {
                Console.WriteLine("Please, enter value");
                if (int.TryParse(Console.ReadLine(), out x) && Check_number(x) && x > 0)
                {
                    Reverse(x);
                }
                else
                {
                    Console.WriteLine("Incorrect input");
                }
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
