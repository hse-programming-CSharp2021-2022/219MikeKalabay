using System;

namespace Task01
{
    class Program
    {
        static void GetAns(int a, int b, out int gcd, out int lcm)
        {
            lcm = a * b;
            while (b != 0)
            {
                a %= b;
                a = a ^ b;
                b = b ^ a;
                a = a ^ b;
            }
            gcd = a;
            lcm /= gcd;
        }

        static void Main(string[] args)
        {
            int a, b, gcd, lcm;
            do
            {
                Console.WriteLine("Please, enter value");
                if (int.TryParse(Console.ReadLine(), out a) && int.TryParse(Console.ReadLine(), out b))
                {
                    GetAns(a, b, out gcd, out lcm);
                    Console.WriteLine(gcd);
                    Console.WriteLine(lcm);
                }
                else
                {
                    Console.WriteLine("Incorrect input");
                }
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}