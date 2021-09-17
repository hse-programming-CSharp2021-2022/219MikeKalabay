using System;

namespace Task01
{
    class Program
    {
        public static int Rec(int m, int n)
        {
            if (m == 0)
            {
                return n + 1;
            }

            if (m > 0 && n == 0)
            {
                return Rec(m - 1, 1);
            }

            return Rec(m - 1, Rec(m, n - 1));
        }

        static void Main(string[] args)
        {
            int n, m;
            if (int.TryParse(Console.ReadLine(), out m) && int.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine(Rec(m, n));
            }
        }
    }
}
