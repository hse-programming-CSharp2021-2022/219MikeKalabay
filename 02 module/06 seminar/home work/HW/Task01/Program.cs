using System;
using System.Collections.Generic;
using System.IO;

namespace Task01
{
    class RandomEx : Exception
    {
        public RandomEx(string m="abacabadabacaba") : base(m)
        {
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] a = new int[1];
                Console.WriteLine(a[12]);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(1);
                Console.WriteLine(e.Message);
            }

            try
            {
                int c = 0;
                int abc = 1 / c;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(2);
                Console.WriteLine(e.Message);
            }

            try
            {
                int nnnnn = int.Parse("abc");
            }
            catch (FormatException e)
            {
                Console.WriteLine(3);
                Console.WriteLine(e.Message);
            }

            try
            {
                List<string> data = new List<string>();
                for (int i = 0; i < 5; i++)
                {
                    data[i] = "abc";
                }
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(4);
                Console.WriteLine(e.Message);
            }

            try
            {
                StreamReader f = new StreamReader("abc");
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(5);
                Console.WriteLine(e.Message);
            }

            try
            {
                int[] a = new int[10000000000000];
            }
            catch (OverflowException e)
            {
                Console.WriteLine(6);
                Console.WriteLine(e.Message);
            }

            try
            {
                string[,,,] a3 = new string[1002, 1000, 1002, 1200];
            }
            catch (OutOfMemoryException e)
            {
                Console.WriteLine(7);
                Console.WriteLine(e.Message + " Сообщение = 6, но тип ошибки другой!");
            }

            try
            {
                object ccc = "12";
                char cc = (char)(ccc);
            }
            catch (InvalidCastException e)
            {
                Console.WriteLine(8);
                Console.WriteLine(e.Message);
            }

            try
            {
                Math.Sign(Double.NaN);
            } 
            catch (ArithmeticException e)
            {
                Console.WriteLine(9);
                Console.WriteLine(e.Message);
            }

            try
            {
                throw new RandomEx();
            }
            catch (RandomEx e)
            {
                Console.WriteLine(10);
                Console.WriteLine(e.Message);
            }
        }
    }
}
