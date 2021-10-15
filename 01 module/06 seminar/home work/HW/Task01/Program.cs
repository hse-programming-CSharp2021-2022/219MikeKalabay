using System;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] mas = new int[n];
            for (var i = 0; i < n; ++i)
            {
                mas[i] = int.Parse(Console.ReadLine());
            }
            for (var i = 0; i < n - 1; ++i)
            {
                if ((mas[i] + mas[i + 1]) % 3 == 0)
                {
                    Console.Write(mas[i] * mas[i + 1] + " ");
                    i += 1;
                }
                else
                {
                    Console.Write(mas[i] + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
