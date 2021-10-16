using System;
using System.Text;

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string[] a = s.Split(' ');
            StringBuilder ans1 = new StringBuilder();
            int ans2 = 0;
            int ans3 = 0;
            for (int i = 0; i < a.Length; ++i)
            {
                if (a[i] != "")
                {
                    if (a[i][0] >= 'А' && a[i][0] <= 'Я')
                    {
                        ans3 += 1;
                    }
                    if (a[i].Length > 4)
                    {
                        ans2 += 1;
                    }
                    for (int j = 0; j < a[i].Length; ++j)
                    {
                        ans1.Append(a[i][j]);
                    }
                    ans1.Append(' ');
                }
            }
            //первое задание
            Console.WriteLine(ans1);
            //второе задание
            Console.WriteLine(ans2);
            //третье задание
            Console.WriteLine(ans3);
        }
    }
}
