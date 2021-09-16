using System;

namespace Task01
{
    class Program
    {
        public static bool Check_number(int x)
        {
            int cnt = 0;
            while (x != 0) 
            {
                x /= 10;
                cnt += 1;
            }
            return (cnt == 3);
        }

        public static int Count_sort(int x)
        {
            int[] cnt = new int[10];
            int ans = 0;
            cnt[x % 10] += 1;
            cnt[(x / 10) % 10] += 1;
            cnt[x / 100] += 1;
            for (int i = 9; i >= 0; --i) 
            {
                while (cnt[i] != 0) 
                {
                    ans = ans * 10 + i;
                    cnt[i] -= 1;
                }
            }
            return ans;
        }

        static void Main(string[] args)
        {
            int x;
            do
            {
                //Console.WriteLine("Please, enter value");
                if (int.TryParse(Console.ReadLine(), out x) && Check_number(x))
                {
                    Console.WriteLine(Count_sort(x));
                }
                else
                {
                    Console.WriteLine("Incorrect input");
                }
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
