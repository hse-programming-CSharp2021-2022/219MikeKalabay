using System;

namespace Task01
{
    class Program
    {
        public static void Sums(uint number, out uint sumEven, out uint sumOdd)
        {
            sumEven = 0;
            sumOdd = 0;
            int i = 0;
            while (number != 0)
            {
                if (i % 2 == 1)
                {
                    sumEven += number % 10;
                }
                else
                {
                    sumOdd += number % 10;
                }
                number /= 10;
                i += 1;
            }
        }

        static void Main(string[] args)
        {
            uint n, sumEven, sumOdd;
            if (uint.TryParse(Console.ReadLine(), out n))
            {
                Sums(n, out sumEven, out sumOdd);
                Console.WriteLine(sumEven);
                Console.WriteLine(sumOdd);
            }
        }
    }
}