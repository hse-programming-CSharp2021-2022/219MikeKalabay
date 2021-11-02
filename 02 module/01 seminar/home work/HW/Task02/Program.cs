using System;
using System.Collections.Generic;

namespace Task02
{
    public class Polygon
    {
        int numb;
        double radius;
        public Polygon(int n = 3, double r = 1)
        {
            numb = n;
            radius = r;
        }
        public double Perimeter
        {
            get
            {
                return 2 * radius * numb * Math.Tan(Math.PI / numb);
            }
        }
        public double Area
        {
            get
            {
                return 2 * radius * radius * numb * Math.Tan(Math.PI / numb) / 2;
            }
        }
        public bool Check()
        {
            return !(numb == 0 && radius == 0);
        }
        public string PolygonData()
        {
            string res = string.Format("N={0}; R={1}; P={2,2:F3}; S={3,4:F3}",
            numb, radius, Perimeter, Area);
            return res;
        }
    }

    public class Program
    {
        public static void Main()
        {
            Polygon polygon = new Polygon();
            Console.WriteLine("По умолчанию создан многоугольник: ");
            Console.WriteLine(polygon.PolygonData());
            double rad;
            int i_max = 0;
            int i_min = 0;
            List<Polygon> ans = new List<Polygon>();
            int number;
            int now = 0;
            do
            {
                do Console.Write("Введите число сторон: ");
                while (!int.TryParse(Console.ReadLine(), out number) | (number < 3 && number != 0));
                do Console.Write("Введите радиус: ");
                while (!double.TryParse(Console.ReadLine(), out rad) | rad < 0);
                polygon = new Polygon(number, rad);
                if (polygon.Check()) {
                    ans.Add(polygon);
                    if (polygon.Area <= ans[i_min].Area)
                    {
                        i_min = now;
                    }
                    if (polygon.Area > ans[i_max].Area)
                    {
                        i_max = now;
                    }
                }
                now += 1;
            } while (polygon.Check());
            for (int i = 0; i < ans.Count; ++i)
            {
                if (i == i_min)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                if (i == i_max)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                Console.WriteLine(ans[i].PolygonData());
                if (i == i_min || i == i_max)
                {
                    Console.ResetColor();
                }
            }
        }
    }
}