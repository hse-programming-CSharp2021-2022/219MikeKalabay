using System;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] mas = new int[n];
            var rand = new Random();
            for (var i = 0; i < n; ++i)
            {
                mas[i] = rand.Next(-10, 10);
            }
            int ans = 0;
            int cnt = 0;
            for (var i = 0; i < n - 1; ++i)
            {
                cnt += 1;
                if ((mas[i] + mas[i + 1]) % 3 == 0)
                {
                    ans += cnt;
                    cnt = 0;
                    Console.Write(mas[i] * mas[i + 1] + " ");
                    i += 1;
                }
                else
                {
                    Console.Write(mas[i] + " ");
                }
            }
            Console.WriteLine();
            Console.WriteLine(ans);
        }
    }
}
