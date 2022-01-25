using System;

namespace Task02
{

    public delegate double DelegateConvertTemperature(double x);

    class TemperatureConverterImp
    {
        public double FToC(double x)
        {
            return 5.0 * (x - 32) / 9;
        }

        public double CToF(double x)
        {
            return 9.0 * x / 5 + 32;
        }
    }

    class StaticTempConverters
    {
        public static double KToC(double x)
        {
            return x - 273.15;
        }

        public static double CToK(double x)
        {
            return x + 273.15;
        }

        public static double RankinToC(double x)
        {
            return (x - 491.67) * 5 / 9;
        }

        public static double CToRankin(double x)
        {
            return (x + 273.15) * 9 / 5;
        }

        public static double RéaumurToC(double x)
        {
            return x * 5 / 4;
        }

        public static double CToRéaumur(double x)
        {
            return x * 4 / 5;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            DelegateConvertTemperature now1 = new DelegateConvertTemperature(new TemperatureConverterImp().FToC);
            DelegateConvertTemperature now2 = new DelegateConvertTemperature(new TemperatureConverterImp().CToF);
            Console.WriteLine(now1(9 + 32));
            Console.WriteLine(now2(5));

            DelegateConvertTemperature[] delegates = new DelegateConvertTemperature[5];
            delegates[0] = now1;
            delegates[1] = now2;

            delegates[2] = new DelegateConvertTemperature(StaticTempConverters.CToK);
            delegates[3] = new DelegateConvertTemperature(StaticTempConverters.CToRankin);
            delegates[4] = new DelegateConvertTemperature(StaticTempConverters.CToRéaumur);
            double x;
            if (double.TryParse(Console.ReadLine(), out x))
            {
                Console.WriteLine("Фаренгейт: " + delegates[1].Invoke(x));
                Console.WriteLine("Кельвинт: " + delegates[2].Invoke(x));
                Console.WriteLine("Ранкин: " + delegates[3].Invoke(x));
                Console.WriteLine("Реомюр: " + delegates[4].Invoke(x));
            }
        }
    }
}
