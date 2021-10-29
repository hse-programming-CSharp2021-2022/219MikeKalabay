using System;

namespace Task01
{
    class MyComplex
    {
        public double im { get; }
        public double re { get; }
        public MyComplex(double xre, double xim)
        { re = xre; im = xim; }
        public static MyComplex operator ++(MyComplex mc)
        { return new MyComplex(mc.re + 1, mc.im + 1); }
        public static MyComplex operator --(MyComplex mc)
        { return new MyComplex(mc.re - 1, mc.im - 1); }
        public double Mod() { return Math.Abs(re * re + im * im); }
        static public bool operator true(MyComplex f)
        {
            if (f.Mod() > 1.0) return true;
            return false;
        }
        static public bool operator false(MyComplex f)
        {
            if (f.Mod() <= 1.0) return true;
            return false;
        }
        static public MyComplex operator +(MyComplex a, MyComplex b)
        {
            return new MyComplex(a.re + b.re, a.im + b.im);
        }
        static public MyComplex operator -(MyComplex a, MyComplex b)
        {
            return new MyComplex(a.re - b.re, a.im - b.im);
        }
        static public MyComplex operator *(MyComplex a, MyComplex b)
        {
            return new MyComplex(a.re * b.re - a.im * b.im, a.im * b.re + a.re * b.im);
        }
        static public MyComplex operator /(MyComplex a, MyComplex b)
        {
            return new MyComplex((a.re * b.re + a.im * b.im) / (b.re * b.re + b.im * b.im), (a.im * b.re - a.re * b.im) / (b.re * b.re + b.im * b.im));
        }
        public override string ToString()
        {
            return re.ToString() + " " + im.ToString() + "∙I";
        }
    }
    class Program
    {
        static void Main()
        {
            MyComplex num1 = new MyComplex(1, 2);
            MyComplex num2 = new MyComplex(-2, -3);
            Console.WriteLine(num1 + num2);
            Console.WriteLine(num1 - num2);
            Console.WriteLine(num2 - num1);
            Console.WriteLine(num1 * num2);
            Console.WriteLine(num1 / num2);
            Console.WriteLine(num2 / num1);
        }
    }
}