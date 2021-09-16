using System;

namespace Task05
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            c = Math.Sqrt(a * a + b * b);
            Console.WriteLine(c);
        }
    }
}
