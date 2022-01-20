using System;

namespace Task01
{
    delegate int[] Row(int n);
    delegate void Print(int[] a);
    class Program
    {
        static int[] GetNums(int n)
        {
            int[] res = new int[n.ToString().Length];
            int i = 0;
            while (n != 0)
            {
                res[i] = n % 10;
                n /= 10;
                i += 1;
            }
            return res;
        }
        static void PrintNum(int[] a)
        {
            foreach (int elem in a)
            {
                Console.WriteLine(elem);
            }
        }
        static void Main(string[] args)
        {
            int u = 54321;
            int[] a = { 12, 23, 34, 45, 56, 67, 78, 89, 91, 12 };
            Row row = new Row(GetNums);
            Print print = new Print(PrintNum);
            print(a);
            print(row(u));
            Console.WriteLine(row.Method);
            Console.WriteLine(row.Target);
            Console.WriteLine(print.Method);
            Console.WriteLine(print.Target);
        }
    }
}