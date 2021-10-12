using System;

namespace Task02
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Не было второго задания.");
            int variable = 1;
            switch (variable)
            {
                case 1:
                    Console.WriteLine("case 1");
                case 2:
                    Console.WriteLine("case 2");
                    break;
                default:
                    Console.WriteLine("default");
                    break;
            }

        }
    }
}
