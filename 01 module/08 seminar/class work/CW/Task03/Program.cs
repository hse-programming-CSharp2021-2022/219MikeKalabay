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

        public static int Comp1(int a, int b)
        {
            if (a % 2 == 0)
            {
                return -1;
            }
            return 1;
        }

        public static (int, int) Get_ans(int a)
        {
            int s = 0;
            int cnt = 0;
            if (a == 0)
            {
                return (1, 0);
            }
            while (a != 0)
            {
                cnt += 1;
                s += a % 10;
                a /= 10;
            }
            return (cnt, s);
        }

        public static int Comp2(int a, int b)
        {
            int cnt1 = Get_ans(a).Item1;
            int cnt2 = Get_ans(b).Item1;
            if (cnt1 < cnt2)
            {
                return 1;
            }
            return -1;
        }

        public static int Comp3(int a, int b)
        {
            int cnt1 = Get_ans(a).Item2;
            int cnt2 = Get_ans(b).Item2;
            if (cnt1 < cnt2)
            {
                return 1;
            }
            return -1;
        }

        public static bool Check(int a)
        {
            int n1 = a % 10;
            int n2 = (a / 10) % 10;
            int n3 = (a / 100) % 10;
            int n4 = (a / 1000) % 10;
            return n1 == n4 && n2 == n3;
        }

        static void Main(string[] args)
        {
            int n;
            int.TryParse(Console.ReadLine(), out n);
            int[] mas = new int[n];
            for (int i = 0; i < n; ++i)
            {
                mas[i] = Rand(1000, 9999);
            }
            Array.ForEach(mas, el => Console.Write(el + " "));
            Console.WriteLine();
            int[] mas2 = Array.FindAll(mas, Check);
            Array.ForEach(mas2, el => Console.Write(el + " "));
            Console.WriteLine();
        }
    }
}
