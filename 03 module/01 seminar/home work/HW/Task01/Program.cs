using System;

namespace Task01
{
    public delegate int Cast(double x);

    class Program
    {
        static void Main(string[] args)
        {
            Cast now1 = delegate (double x)
            {
                return ((int)x + 1) / 2 * 2;
            };
            Cast now2 = delegate (double x)
            {
                return (((int)x).ToString()).Length;
            };
            Console.WriteLine(now1(1.56));
            Console.WriteLine(now1(0.9));
            Console.WriteLine(now2(1.56));
            Console.WriteLine(now2(179.9));
            for (int i = 0; i < 5; ++i)
            {
                Random rand = new Random();
                double now = rand.NextDouble() * 100;
                Console.WriteLine(now1(now));
                Console.WriteLine(now2(now));
            }
            Cast now3 = now1;
            now3 += now2;
            Console.WriteLine(now3(1.56));
            Console.WriteLine(now3(179.9));
            Cast now11 = x => ((int)x + 1) / 2 * 2;
            Cast now22 = x => (((int)x).ToString()).Length;
            Console.WriteLine(now3.Invoke(179.9));
            now3 -= now22;
            Console.WriteLine(now3.Invoke(179.9));
            now3 -= now11;
            Console.WriteLine(now3.Invoke(179.9));
            now3 -= now2;
            Console.WriteLine(now3.Invoke(179.9));
            now3 -= now1;
            //Console.WriteLine(now3.Invoke(179.9));
            Console.WriteLine("Ничего не осталось :(");
        }
    }
}
