using System;

namespace ASCIIDecoder
{
    class Program
    {
        static void Main(string[] args)
        {
            byte num = Byte.Parse(Console.ReadLine());
            Console.WriteLine((char)num);
        }
    }
}