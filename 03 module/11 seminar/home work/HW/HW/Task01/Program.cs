using System;
using System.IO;
using System.Collections.Generic;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            List<int> a = new List<int>();
            using (BinaryWriter wr = new BinaryWriter(File.Open("Numbers.txt", FileMode.OpenOrCreate)))
            {
                for (int i = 0; i < 10; i++)
                {
                    wr.Write(rand.Next(1, 100));
                }
            }
            using (BinaryReader rd = new BinaryReader(File.Open("Numbers.txt", FileMode.OpenOrCreate)))
            {
                for (var i = 0; i < 10; i++)
                {
                    a.Add(rd.ReadInt32());
                    Console.WriteLine(a[a.Count - 1]);
                }
                int n = int.Parse(Console.ReadLine());
                int min = 200000;
                int ind = 0;
                for (int i = 0; i < a.Count; i++)
                {
                    if (min > Math.Abs(a[i] - n))
                    {
                        min = Math.Abs(a[i] - n);
                        ind = i;
                    }
                }
                a[ind] = n;
            }
            using (var writer = new BinaryWriter(File.Open("Numbers.txt", FileMode.OpenOrCreate)))
            {
                for (int i = 0; i < a.Count; i++)
                {
                    writer.Write(a[i]);
                }
            }
        }
    }
}