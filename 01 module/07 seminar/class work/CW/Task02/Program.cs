using System;

namespace Task01
{
    class Program
    {
        public static int Rand(int l, int r)
        {
            Random rand = new Random();
            return l + rand.Next() % (r - l + 1);
        }

        public static int[] Number_generator(int n = 100)
        {
            int[] ans = new int[n];
            int now = Rand(1, 100);
            ans[0] = now;
            for (int i = 1; i < n; ++i)
            {
                while (true)
                {
                    now = Rand(1, 100);
                    bool check = true;
                    for (int j = 0; j < i; ++j)
                    {
                        if (now == ans[j])
                        {
                            check = false;
                            break;
                        }
                    }
                    if (check)
                    {
                        break;
                    }
                }
                ans[i] = now;
            }
            int ind = Rand(0, 99);
            now = Rand(1, 100);
            while (ans[ind] == now)
            {
                now = Rand(1, 100);
            }
            ans[ind] = now;
            return ans;
        }

        static void Main(string[] args)
        {
            int[] mas = Number_generator();
            int s1 = 0;
            for (int i = 0; i < 100; ++i)
            {
                s1 ^= mas[i];
            }
            for (int i = 1; i <= 100; ++i)
            {
                s1 ^= i;
            }
            int s2 = 5050 - s1;
            for (int i = 0; i < 100; ++i)
            {
                s2 -= mas[i];
            }
            Console.WriteLine(-s2);
        }
    }
}