using System;
using System.Collections;
namespace Task01
{
    class Fibbonacci
    {
        int s = 1, n = 0;
        public IEnumerable NextMemb(int limit)
        {
            int t;
            for (int i = 0; i < limit; ++i)
            {
                t = s + n;
                s = n;
                yield return n = t;
            }
        }
    }

    class TriangleNums : IEnumerable
    {
        int s = 0;
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < 10; ++i)
            {
                yield return s;
                s = i * (i + 1) / 2;
            }
        }

        public IEnumerable Enumerator(int n)
        {
            for (int i = 0; i < n; ++i)
            {
                yield return s;
                s = i * (i + 1) / 2;
            }
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            int[] res = new int[5];
            TriangleNums a = new TriangleNums();
            int j = 0;
            Fibbonacci b = new Fibbonacci();
            foreach (var now in b.NextMemb(5))
            {
                res[j] += (int)now;
                j += 1;
            }
            j = 0;
            foreach (var now in a.Enumerator(5))
            {
                res[j] += (int)now;
                j += 1;
            }
            foreach (var now in res)
            {
                Console.WriteLine(now);
            }
        }
    }
}