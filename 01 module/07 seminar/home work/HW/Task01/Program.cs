using System;
using System.Collections.Generic;

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
            int now = Rand(1, n);
            ans[0] = now;
            for (int i = 1; i < n; ++i)
            {
                while (true)
                {
                    now = Rand(1, n);
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
            int ind = Rand(0, n - 1);
            now = Rand(1, n);
            while (ans[ind] == now)
            {
                now = Rand(1, n);
            }
            Console.WriteLine(ans[ind] + " " + now + " убрал, добавил");
            ans[ind] = now;
            return ans;
        }

        static void Main(string[] args)
        {
            int[] mas = Number_generator(10);
            for (int i = 0; i < mas.Length; ++i)
            {
                Console.Write(mas[i] + " ");
            }
            Console.WriteLine();
            HashSet<int> s = new HashSet<int>();
            int ans = -1;
            for (var i = 0; i < mas.Length; ++i)
            {
                if (s.Contains(mas[i]))
                {
                    ans = mas[i];
                    break;
                }
                s.Add(mas[i]);
            }
            Console.WriteLine(ans);
            int s1 = 0;
            int s2 = 0;
            for (int i = 0; i < mas.Length; ++i)
            {
                s2 ^= mas[i];
            }
            for (int i = 0; i < mas.Length; ++i)
            {
                s1 ^= i + 1;
            }
            Console.WriteLine(s1 ^ s2 ^ ans);
        }
    }
}