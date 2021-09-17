using System;

namespace Task01
{
    class Program
    {
        public static int Cnt(int n)
        {
            int i = 2;
            int ans = 2;
            while (i * i <= n)
            {
                if (n % i == 0)
                {
                    ans += 1;
                    if (i != n / i)
                    {
                        ans += 1;
                    }
                }
                i += 1;
            }

            return ans;
        }

        static void Main(string[] args)
        {
            int k;
            if (int.TryParse(Console.ReadLine(), out k))
            {
                for (int i = 100; i < 1000; ++i)
                {
                    if (Cnt(i) == k)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }
    }
}