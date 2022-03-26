using System;
using System.Linq;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            Random rand = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = rand.Next(-1000, 1001);
            }
            int[] res1 = a.Select(x => x * x).ToArray();
            for (int i = 0; i < res1.Length; ++i)
            {
                Console.WriteLine(res1[i]);
            }
            int[] res2 = a.Where(x => ((x < 1000) && (x >= 100))).ToArray();
            for (int i = 0; i < res2.Length; ++i)
            {
                Console.WriteLine(res2[i]);
            }
            int[] res3 = a.Where(x => x % 2 == 0).OrderByDescending(x => -x).ToArray();
            for (int i = 0; i < res3.Length; ++i)
            {
                Console.WriteLine(res3[i]);
            }
            var res4 = a.GroupBy(x => x.ToString().Length).ToArray();
        }
    }
}
