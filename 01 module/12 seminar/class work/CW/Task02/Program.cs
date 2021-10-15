using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Task02
{
    class Program
    {
        static public bool Check(string s)
        {
            string s2 = "";
            for (int i = s.Length - 1; i >= 0; --i)
            {
                s2 += s[i];
            }
            return s2 == s;
        }

        static public int Cmp1(string s1)
        {
            return int.Parse(s1);
        }

        static public (int, int) Cmp2(string s1)
        {
            int res = 0;
            for (int i = 0; i < s1.Length; ++i)
            {
                res += s1[i] - '0';
            }
            return (res, int.Parse(s1));
        }

        static public int Search(string s1)
        {
            int max = 0;
            for (int i = 0; i < s1.Length; ++i)
            {
                max = Math.Max(max, s1[i] - '0');
            }
            return max;
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] a = new string[n];
            int[] b = new int[n];
            Random rnd = new Random();
            for (var i = 0; i < n; ++i)
            {
                b[i] = rnd.Next(1, 10000);
                Console.Write(b[i] + " ");
                a[i] = b[i].ToString();
            }
            Console.WriteLine("");
            Console.WriteLine("================================================================");

            var c1 = from t in a
                    where (t.Length == 2 && int.Parse(t) % 3 == 0)
                    select t;

            foreach (string s in c1)
                Console.WriteLine(s);
            Console.WriteLine("================================================================");
            var c2 = from t in a
                     where Check(t)
                     select t;

            var c3 = c2.OrderBy(s => Cmp1(s));
            foreach (string s in c3)
                Console.WriteLine(s);
            Console.WriteLine("================================================================");
            var c4 = from t in a
                     where true
                     select t;

            var c5 = c2.OrderBy(s => Cmp2(s));
            foreach (string s in c3)
                Console.WriteLine(s);
            Console.WriteLine("================================================================");
            var c6 = from t in a
                     where t.Length == 4
                     select t;

            int sum = 0;
            foreach (string s in c6)
                sum += int.Parse(s);
            Console.WriteLine(sum);
            Console.WriteLine("================================================================");
            var c7 = from t in a
                     where t.Length == 2
                     select t;

            int min = int.MaxValue;
            foreach (string s in c7)
                min = Math.Min(min, int.Parse(s));
            Console.WriteLine(min);
            Console.WriteLine("================================================================");
            List<int> c8 = new List<int>();
            for (int i = 0; i < n; ++i)
            {
                c8.Add(Search(a[i]));
            }
            foreach (int s in c8)
                Console.WriteLine(s);
        }
    }
}
