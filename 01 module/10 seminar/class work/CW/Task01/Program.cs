using System;
using System.Text;

namespace Task01
{
    class Program
    {
        private static Random rnd = new();

        static char[] GetAns(int n, int per)
        {
            char[] arr = new char[n];
            int letterCount = (int)(n * per / 100.0);
            for (int i = 0; i < letterCount; ++i)
            {
                arr[i] = (char)rnd.Next('a', 'z');
            }
            for (int i = letterCount; i < n; ++i)
            {
                arr[i] = (char)rnd.Next('0', '9');
            }
            return arr;
        }

        static string Line(char[] series)
        {
            string[] letters = { "ноль", "один", "два", "три", "четыре", "пять", "шесть", "семь", "восемь", "девять" };
            string sb = "";
            for (int i = 0; i < series.Length; ++i)
            {
                if (series[i] >= '0' && series[i] <= '9')
                {
                    int index = series[i] - '0';
                    sb += letters[index] + " ";
                }
                else
                {
                    sb += series[i] + " ";
                }
            }
            return sb;
        }

        static string Line2(char[] series)
        {
            string[] letters = { "ноль", "один", "два", "три", "четыре", "пять", "шесть", "семь", "восемь", "девять" };
            StringBuilder sb = new();
            for (int i = 0; i < series.Length; ++i)
            {
                if (series[i] >= '0' && series[i] <= '9')
                {
                    int index = series[i] - '0';
                    sb.Append(letters[index] + " ");
                }
                else
                {
                    sb.Append(series[i] + " ");
                }
            }
            return sb.ToString();
        }

        static void Main(string[] args)
        {
            char[] arr = GetAns(10, 30);
            Array.ForEach(arr, x => Console.Write(x + " "));
            Console.WriteLine();
            Console.WriteLine(Line(arr));
            Console.WriteLine(Line2(arr));
        }
    }
}
