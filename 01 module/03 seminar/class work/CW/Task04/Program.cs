using System;

namespace ASCIIDecoder
{
    class Program
    {
        public static string Reverse(string s)
        {
            string ans = "";
            for (int i = s.Length - 1; i >= 0; --i)
            {
                ans += s[i];
            }
            return ans;
        }
        public static void Function1(string num)
        {
            num = Reverse(num);
            int ans = 0;
            for (int i = 0; i < num.Length; ++i)
            {
                ans = ans * 10 + (num[i] - '0');
            }
            Console.WriteLine(ans);
        }

        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            Function1(num);
        }
    }
}

