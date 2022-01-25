using System;

namespace Task01
{
    class Plant
    {
        double growth;
        double photosensitivity;
        double frostresistance;

        public double Growth
        {
            get
            {
                return growth;
            }
            set
            {
                growth = value;
            }
        }

        public double Photosensitivity
        {
            get
            {
                return photosensitivity;
            }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    photosensitivity = value;
                }
                else
                {
                    Random rand = new Random();
                    photosensitivity = rand.Next(0, 101);
                }
            }
        }

        public double Frostresistance
        {
            get
            {
                return frostresistance;
            }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    frostresistance = value;
                }
                else
                {
                    Random rand = new Random();
                    frostresistance = rand.Next(0, 101);
                }
            }
        }

        public Plant(double growth, double photosensiuvity, double frostresistance)
        {
            Growth = growth;
            Photosensitivity = photosensiuvity;
            Frostresistance = frostresistance;
        }

        public override string ToString()
        {
            return "growth: " + Growth + " photosensitivity: " + Photosensitivity + " frostresistance: " + Frostresistance;
        }
    }

    class Program
    {
        static void GetStr(Plant x)
        {
            Console.WriteLine(x);
        }

        static int Comp(Plant x, Plant y)
        {
            if (y.Photosensitivity % 2 == 0)
            {
                return -1;
            }
            return 1;
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Plant[] a = new Plant[n];
            for (int i = 0; i < n; ++i)
            {
                Random rand = new Random();
                a[i] = new Plant(rand.Next(25, 101), rand.Next(0, 101), rand.Next(0, 81));
            }
            Array.ForEach(a, GetStr);
            Console.WriteLine();
            Array.Sort(a, delegate (Plant x, Plant y) { if (x.Growth < y.Growth) return -1; else return 1; });
            Array.ForEach(a, GetStr);
            Console.WriteLine();
            Array.Sort(a, (Plant x, Plant y) => { if (x.Frostresistance < y.Frostresistance) return -1; else return 1; });
            Array.ForEach(a, GetStr);
            Console.WriteLine();
            Array.Sort(a, Comp);
            Array.ForEach(a, GetStr);
            Console.WriteLine();
            Array.ConvertAll(a, (Plant x) => new Plant(x.Growth, x.Photosensitivity, (x.Frostresistance % 2 == 0) ? (x.Frostresistance / 3) : (x.Frostresistance / 2)));
            Array.ForEach(a, GetStr);
        }
    }
}
