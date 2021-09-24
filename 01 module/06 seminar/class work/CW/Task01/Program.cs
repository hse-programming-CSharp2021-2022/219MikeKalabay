using System;

namespace Task01
{
    class Program
    {
        public static int Get_ans(int n, int ind, int len)
        {
            for (int i = 0; i < len - 1 - ind; ++i)
            {
                n /= 10;
            } 
            return n % 10;
        }

        static void Main(string[] args)
        {
            int n;
            if (int.TryParse(Console.ReadLine(), out n))
            {
                int len = 0;
                int n_copy = n;
                while (n_copy != 0)
                {
                    len += 1;
                    n_copy /= 10;
                }
                for (int i = 0; i < len; ++i)
                {
                    int num = Get_ans(n, i, len);
                    int swap = i;
                    for (int j = 0; j < i; ++j)
                    {
                        if (num > Get_ans(n, j, len))
                        {
                            swap = j;
                            break;
                        }
                    }
                    if (swap != i)
                    {
                        int new_n = 0;
                        int j = 0;
                        while (j < swap)
                        {
                            if (j != i)
                            {
                                new_n = new_n * 10 + Get_ans(n, j, len);
                            }
                            j += 1;
                        }
                        new_n = new_n * 10 + num;
                        while (j < len)
                        {
                            if (j != i)
                            {
                                new_n = new_n * 10 + Get_ans(n, j, len);
                            }
                            j += 1;
                        }
                        n = new_n;
                    }
                }
                Console.WriteLine(n);
            }
        }
    }
}
