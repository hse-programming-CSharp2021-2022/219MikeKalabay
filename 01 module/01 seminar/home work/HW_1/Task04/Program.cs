using System;

namespace Task04
{
    class Program
    {
        static void Main(string[] args)
        {
            double U, R, I, P;
            U = double.Parse(Console.ReadLine());
            R = double.Parse(Console.ReadLine());
            I = U / R;
            P = U * U / R;
            Console.WriteLine(I);
            Console.WriteLine(P);
        }
    }
}
