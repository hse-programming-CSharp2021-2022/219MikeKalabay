using System;

namespace Task01
{
    class Program
    {
        public static bool Shift(ref char ch)
        {
            if ('a' <= ch && ch <= 'z')
            {
                ch = (char)((ch - 'a' + 4) % 26 + (int)'a');
                return true;
            }
            return false;
        }

        static void Main(string[] args)
        {
            char ch;
            do
            {
                Console.WriteLine("Please, enter value");
                if (char.TryParse(Console.ReadLine(), out ch))
                {
                    if (!Shift(ref ch))
                    { 
                        Console.WriteLine("Incorrect input");
                        continue;
                    }
                    Console.WriteLine(ch);
                }
                else
                {
                    Console.WriteLine("Incorrect input");
                }
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}