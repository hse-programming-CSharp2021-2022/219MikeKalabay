using System;
using System.Collections.Generic;

namespace Task01
{
    class Program
    {
        class Point
        {
            public double X { get; set; }

            public double Y { get; set; }

            public Point(double x, double y)
            {
                X = x;
                Y = y;
            }

            public double Distance(Point p)
            {
                return Math.Sqrt((X - p.X) * (X - p.X) + (Y - p.Y) * (Y - p.Y));
            }

            public override string ToString()
            {
                return "Point " + X.ToString() + " " + Y.ToString();
            }
        }

        class Circle : IComparable
        {
            public Point center { get; set; }

            public double Rad { get; set; }

            public Circle(double x, double y, double radius)
            {
                center = new Point(x, y);
                Rad = radius;
            }

            public override string ToString()
            {
                return "Circle " + Rad + " " + center;
            }

            public int CompareTo(object a)
            {
                if (a is Circle x)
                {
                    Point p0 = new Point(0, 0);
                    if (Rad * center.Distance(p0) > x.Rad * x.center.Distance(p0))
                    {
                        return 1;
                    }
                    else if (x.Rad * x.center.Distance(p0) == x.Rad * x.center.Distance(p0))
                    {
                        return 0;
                    }
                }
                return -1;
            }
        }

        struct CircleStruct
        {
            public PointStruct center { get; set; }

            public double Rad { get; set; }

            public CircleStruct(double x, double y, double radius)
            {
                center = new PointStruct(x, y);
                Rad = radius;
            }

            public override string ToString()
            {
                return "CircleStruct " + Rad + " " + center;
            }
        }

        struct PointStruct
        {
            public double X { get; set; }
            public double Y { get; set; }

            public PointStruct(double x, double y) => (X, Y) = (x, y);

            public double Distance(Point p) => Math.Sqrt(Math.Pow(X - p.X, 2) + Math.Pow(Y - p.Y, 2));

            public override string ToString() => "PointStruct " + X + " " + Y;
        }

        static void Main(string[] args)
        {
            List<Circle> a1 = new List<Circle>();
            List<Circle> a2 = new List<Circle>();
            Random rnd = new Random();
            for (int i = 0; i < 25; ++i)
            {
                a1.Add(new Circle(rnd.Next(0, 179), rnd.Next(0, 179), rnd.Next(0, 179)));
            }
            for (int i = 0; i < 25; ++i)
            {
                a2.Add(new Circle(rnd.Next(0, 179), rnd.Next(0, 179), rnd.Next(0, 179)));
            }
            a1.Sort();
            a2.Sort();
            for (int i = 0; i < 25; ++i)
            {
                Console.WriteLine(a1[i].ToString());
            }
            Console.WriteLine();
            for (int i = 0; i < 25; ++i)
            {
                Console.WriteLine(a2[i].ToString());
            }
        }
    }
}
