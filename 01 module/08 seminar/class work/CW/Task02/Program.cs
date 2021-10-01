using System;

namespace Task01
{
    class Program
    {
        public static double Rand(int l, int r)
        {
            Random rand = new Random();
            return l + rand.Next() % (r - l + 1) + rand.NextDouble();
        }

        static void Main(string[] args)
        {
            int n;
            int.TryParse(Console.ReadLine(), out n);
            double[] mas = new double[n];
            for (int i = 0; i < n; ++i)
            {
                mas[i] = Rand(0, 1000);
            }
            Array.Sort(mas);
            Array.ForEach(mas, el => Console.Write(el + " "));
            Console.WriteLine();
            double[] mas2 = new double[n];
            int[] mas3 = new int[n];
            for (int i = 0; i < n; ++i)
            {
                mas2[i] = mas[i] - (int)mas[i];
            }
            for (int i = 0; i < n; ++i)
            {
                mas3[i] = (int)mas[i];
            }
            Array.Sort(mas2);
            Array.ForEach(mas2, el => Console.Write(el + " "));
            Console.WriteLine();
            Array.Sort(mas3);
            Array.ForEach(mas3, el => Console.Write(el + " "));
            Console.WriteLine();
        }
    }
}
