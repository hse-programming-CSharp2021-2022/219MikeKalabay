using System;

namespace ASCIIDecoder
{
    class Program
    {
        public static bool Function1(bool p, bool q)
        {
            return !(p & q) & !(p | !q);
        }

        public static void Function2(bool p, bool q, out bool ans)
        {
            ans = !(p & q) & !(p | !q);
        }

        static void Main(string[] args)
        {
            bool p = bool.Parse(Console.ReadLine());
            bool q = bool.Parse(Console.ReadLine());
            bool ans;
            Console.WriteLine(Function1(p, q));
            Function2(p, q, out ans);
            Console.WriteLine(ans);
        }
    }
}