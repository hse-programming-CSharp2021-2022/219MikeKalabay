using System;
using System.Collections.Generic;

namespace Task02
{
    class Cinderella
    { 
    
    }

    abstract class Something : Cinderella 
    {
    }

    class Lentil : Something
    {
        private double weight;

        public double Weight
        {
            set
            {
                weight = value;
            }
            get
            {
                return weight;
            }
        }

        public Lentil()
        {
            Random rand = new Random();
            weight = rand.NextDouble() * 2;
        }

        public Lentil(double w)
        {
            weight = w;
        }

        public override string ToString()
        {
            return "Lentil " + weight;
        }
    }

    class Ashes : Something
    {
        private double volume;

        public double Volume
        {
            set
            {
                volume = value;
            }
            get
            {
                return volume;
            }
        }

        public Ashes()
        {
            Random rand = new Random();
            volume = rand.NextDouble();
        }

        public Ashes(double v)
        {
            volume = v;
        }

        public override string ToString()
        {
            return "Ashes " + volume;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Something[] a = new Something[n];
            for (int i = 0; i < n; ++i)
            {
                Random rand = new Random();
                if (rand.Next(0, 2) % 2 == 0)
                {
                    a[i] = new Lentil();
                }
                else
                {
                    a[i] = new Ashes();
                }
                Console.WriteLine(a[i]);
            }
            List<Something> a1 = new List<Something>();
            List<Something> a2 = new List<Something>();
            for (int i = 0; i < n; ++i)
            {
                if (a[i] is Ashes)
                {
                    a2.Add(a[i]);
                }
                else
                {
                    a1.Add(a[i]);
                }
            }
            Console.WriteLine("Lentil:");
            for (int i = 0; i < a1.Count; ++i)
            {
                Console.WriteLine(a1[i]);
            }
            Console.WriteLine("Ashes:");
            for (int i = 0; i < a2.Count; ++i)
            {
                Console.WriteLine(a2[i]);
            }
        }
    }
}
