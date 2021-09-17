using System;

namespace Task01
{
    class Program
    {
        public static double Solve(int num1, int num2, int num3)
        {
            int room1 = num1 % 100;
            int room2 = num2 % 100;
            int room3 = num3 % 100;
            if (room1 < room2)
            {
                if (room1 < room3)
                {
                    return num1;
                }
                return num3;
            }
            if (room2 < room3)
            {
                return num2;
            }
            return num3;
        }

        static void Main(string[] args)
        {
            int num1, num2, num3;
            do
            {
                Console.WriteLine("Please, enter value");
                if (int.TryParse(Console.ReadLine(), out num1) && int.TryParse(Console.ReadLine(), out num2) 
                    && int.TryParse(Console.ReadLine(), out num3) && Math.Min(num1, Math.Min(num2, num3)) >= 100 
                    && Math.Max(num1, Math.Max(num2, num3)) <= 999)
                {
                    Console.WriteLine(Solve(num1, num2, num3));
                }
                else
                {
                    Console.WriteLine("Incorrect input");
                }
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}