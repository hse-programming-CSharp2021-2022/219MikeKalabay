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
            int[,] mas = new int[n , n];
            int i = 0;
            int j = 0;
            int now = 1;
            bool right = true;
            bool up = false;
            bool down = false;
            bool left = false;
            while (now != n * n + 1)
            {
                mas[i, j] = now;
                now += 1;
                if (right)
                {
                    j += 1;
                    if (j == n || mas[i, j] != 0)
                    {
                        right = false;
                        down = true;
                        i += 1;
                        j -= 1;
                    }
                }
                else if (left)
                {
                    j -= 1;
                    if (j == -1 || mas[i, j] != 0)
                    {
                        left = false;
                        up = true;
                        i -= 1;
                        j += 1;
                    }
                }
                else if (up)
                {
                    i -= 1;
                    if (i == -1 || mas[i, j] != 0)
                    {
                        up = false;
                        right = true;
                        i += 1;
                        j += 1;
                    }
                }
                else
                {
                    i += 1;
                    if (i == n || mas[i, j] != 0)
                    {
                        down = false;
                        left = true;
                        i -= 1;
                        j -= 1;
                    }
                }
            }
            for (i = 0; i < n; ++i)
            {
                for (j = 0; j < n; ++j)
                {
                    Console.Write(mas[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
