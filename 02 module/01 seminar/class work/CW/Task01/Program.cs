using System;
using System.Text;
using System.Diagnostics;
using System.Text.RegularExpressions;

class СorrectPolygon
{
    public int Cnt { get; set; }

    public double Radius { get; set; }

    public СorrectPolygon(int cnt = 0, double radius = 0.0)
    {
        Cnt = cnt;
        Radius = radius;
    }

    public double Per()
    {
        return 2 * Math.Tan(Math.PI / (2 * Cnt)) * Radius;
    }

    public double Sq()
    {
        return Cnt * Math.Tan(Math.PI / (2 * Cnt)) * Radius * Radius;
    }
}
class Program
{
    static void Main()
    {
        Console.WriteLine((new СorrectPolygon(7, 7)).Per());
        Console.WriteLine((new СorrectPolygon(7, 7)).Sq());
    }
}