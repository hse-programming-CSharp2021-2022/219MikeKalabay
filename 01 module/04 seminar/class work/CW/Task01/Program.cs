using System;

namespace Task01
{
    class Program
    {
        public static void Solve_double()
        {
            double now = (double)1 / 6;
            double ans = 0;
            int i = 1;
            double prev_ans = -1;
            while (ans > prev_ans)
            {
                prev_ans = ans;
                i += 1;
                ans += now;
                now = (double)1 / (i * (i + 1) * (i + 2));
            }
            Console.WriteLine(ans);
        }

        public static void Solve_float()
        {
            float now = (float)1 / 6;
            float ans = 0;
            int i = 1;
            float prev_ans = -1;
            while (ans > prev_ans)
            {
                prev_ans = ans;
                i += 1;
                ans += now;
                now = (float)1 / (i * (i + 1) * (i + 2));
            }
            Console.WriteLine(ans);
        }

        static void Main(string[] args)
        {
            Solve_double();
            Solve_float();
        }
    }
}