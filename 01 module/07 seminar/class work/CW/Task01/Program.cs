using System;

namespace Task01
{
    class Program
    {

        static void Main(string[] args)
        {
            int k;
            Random rnd = new Random();
            do
            {
                Console.WriteLine("Please, enter value");
                if (int.TryParse(Console.ReadLine(), out k))
                {
                    char[] mas = new char[k];
                    for (int i = 0; i < k; ++i)
                    {
                        int now = rnd.Next() % 26;
                        mas[i] = (char)((int)'A' + now);
                    }
                    Array.ForEach(mas, Console.Write);
                    Console.WriteLine();
                    char[] copy = new char[k];
                    Array.Copy(mas, copy, k);
                    Array.Sort(copy);
                    Array.ForEach(copy, Console.Write);
                    Console.WriteLine();
                    Array.Reverse(copy);
                    Array.ForEach(copy, Console.Write);
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Incorrect input");
                }
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}