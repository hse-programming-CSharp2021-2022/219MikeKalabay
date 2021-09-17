using System;

namespace ASCIIDecoder
{
    class Program
    {
        public static void Function1()
        {
            for (int i = 2; i <= 20; i += 2)
            {
                Console.WriteLine(i * i);
            }
        }

        public static void Function2()
        {
            int i = 2;
            while (i <= 20)
            {
                Console.WriteLine(i * i);
                i += 2;
            }
        }

        public static void Function3()
        {
            int i = 2;
            do
            {
                Console.WriteLine(i * i);
                i += 2;
            } while (i <= 20);
        }

        static void Main(string[] args)
        {
            Function1();
            Console.WriteLine();
            Function2();
            Console.WriteLine();
            Function3();
        }
    }
}