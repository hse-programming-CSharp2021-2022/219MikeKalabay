using System;

namespace Task01
{
    class Program
    {
        public static void Get_ans(uint k)
        {
            double s = 0;
            for (int n = 1; n <= k; ++n)
            {
                s += (n + 0.3) / (3 * n * n + 5);
                Console.WriteLine(s);
            }
        }

        static void Main(string[] args)
        {
            uint k;
            if (uint.TryParse(Console.ReadLine(), out k))
            {
                Get_ans(k);
            }
        }
    }
}