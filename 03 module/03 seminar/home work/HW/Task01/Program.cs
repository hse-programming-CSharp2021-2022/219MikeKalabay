using System;

namespace Task01
{
    delegate void CoordChanged(Dot x);

    class Dot
    {
        double x, y;
        public event CoordChanged OnCoordChanged;
        Random rand = new Random();

        public double X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }

        public double Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }

        public Dot(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public void DotFlow()
        {
            for (int i = 0; i < 10; ++i)
            {
                x = -10 + rand.NextDouble() * 20;
                y = -10 + rand.NextDouble() * 20;
            }
            if (x < 0 && y < 0)
            {
                OnCoordChanged(this);
            }
        }
    }

    class Program
    {
        public static void PrintInfo(Dot A)
        {
            Console.WriteLine(A.X + " " + A.Y);
        }

        static void Main(string[] args)
        {
            double x, y;
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            Dot D = new Dot(x, y);
            D.OnCoordChanged += PrintInfo;
            D.DotFlow();
        }
    }
}
