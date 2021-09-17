using System;

namespace ASCIIDecoder
{
    class Program
    {
        public static void Function1(int num)
        {
            switch (num)
            {
                case <= 3:
                    Console.WriteLine("неудовлетворительно");
                    break;
                case <= 5:
                    Console.WriteLine("удовлетворительно");
                    break;
                case <= 7:
                    Console.WriteLine("хорошо");
                    break;
                case <= 10:
                    Console.WriteLine("отлично");
                    break;
            }
        }

        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Function1(num);
        }
    }
}