using System;

namespace Task01
{
    class Program
    {
        public class Shape
        {
            public const double PI = Math.PI;
            protected double _x, _y;

            public Shape()
            {
            }

            public Shape(double x, double y)
            {
                _x = x;
                _y = y;
            }

            public virtual double Area()
            {
                return _x * _y;
            }
        }

        public class Circle : Shape
        {
            public Circle(double r) : base(r, 0)
            {
            }

            public override double Area()
            {
                return PI * _x * _x;
            }
        }

        public class Sphere : Shape
        {
            public Sphere(double r) : base(r, 0)
            {
            }

            public override double Area()
            {
                return 4 * PI * _x * _x;
            }
        }

        public class Cylinder : Shape
        {
            public Cylinder(double r, double h) : base(r, h)
            {
            }

            public override double Area()
            {
                return 2 * PI * _x * _x + 2 * PI * _x * _y;
            }
        }

        static int Comp(Shape f1, Shape f2)
        {
            int a = 0;
            if (f1 is Circle)
                a = 1;
            else if (f1 is Cylinder)
                a = 3;
            else
                a = 2;
            int b = 0;
            if (f2 is Circle)
                b = 1;
            else if (f2 is Cylinder)
                b = 3;
            else
                b = 2;
            if (a > b) {
                return 1;
            }
            return -1;
        }

        static void Main()
        {
            // Пункт 1.
            Random rand = new Random();
            int[] N = { rand.Next(3, 6), rand.Next(3, 6) , rand.Next(3, 6) };
            Shape[] a = new Shape[N[0] + N[1] + N[2]];
            for (int i = 0; i < N[0]; ++i)
            {
                a[i] = new Circle(rand.Next(1, 12));
            }
            for (int i = 0; i < N[1]; ++i)
            {
                a[i + N[0]] = new Cylinder(rand.Next(1, 12), rand.Next(1, 12));
            }
            for (int i = 0; i < N[2]; ++i)
            {
                a[i + N[0] + N[1]] = new Sphere(rand.Next(1, 12));
            }
            // Пункт 2.
            for (int i = 0; i < a.Length; ++i)
            {
                Console.WriteLine(a[i].Area());
            }
            // Пункт 3.
            for (int i = 0; i < a.Length; ++i)
            {
                if (a[i] is Circle)
                    Console.WriteLine("Circle");
                else if (a[i] is Cylinder)
                    Console.WriteLine("Cylinder");
                else
                    Console.WriteLine("Sphere");
                Console.WriteLine(a[i].Area());
            }
            // Пункт 4.
            Array.Sort(a, Comp);
            for (int i = 0; i < a.Length; ++i)
            {
                if (a[i] is Circle)
                    Console.WriteLine("Circle");
                else if (a[i] is Cylinder)
                    Console.WriteLine("Cylinder");
                else
                    Console.WriteLine("Sphere");
            }
        }
    }
}
