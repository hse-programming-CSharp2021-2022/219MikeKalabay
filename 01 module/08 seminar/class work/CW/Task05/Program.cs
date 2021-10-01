using System;

namespace Task01
{
    class Program
    {
        public static int Rand(int l, int r)
        {
            Random rand = new Random();
            if (rand.Next() % 2 == 0)
            {
                return -(l + rand.Next() % (r - l + 1));
            }
            return l + rand.Next() % (r - l + 1);
        }

        public static int Comp1(int[] a, int[] b)
        {
            Array.Sort(a);
            Array.Sort(b);
            Array.Reverse(a);
            Array.Reverse(b);
            if (a.Length < b.Length)
            {
                return 1;
            }
            return -1;
        }

        static void Main(string[] args)
        {
            int n;
            int.TryParse(Console.ReadLine(), out n);
            int[][] mas = new int[n][];
            for (int i = 0; i < n; ++i)
            {
                int[] mas3 = new int[Math.Abs(Rand(5, 15))];
                for (int j = 0; j < mas3.Length; ++j)
                {
                    mas3[j] = Rand(0, 10);
                }
                mas[i] = mas3;
            }
            for (int i = 0; i < n; ++i)
            {
                Array.ForEach(mas[i], el => Console.Write(el + " "));
                Console.WriteLine();
            }
            Array.Sort(mas, Comp1);
            for (int i = 0; i < n; ++i)
            {
                Array.ForEach(mas[i], el => Console.Write(el + " "));
                Console.WriteLine();
            }
        }
    }
}
