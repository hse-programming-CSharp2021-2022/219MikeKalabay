using System;
delegate int MyDel(int a, int b);

namespace Task02
{
    static class TestClass
    {
        public static int TestMethod(int a, int b)
        {
            return Math.Max(a, b);
        }
    }
    class TestClassNotStatic
    {
        public int TestMethod(int a, int b)
        {
            return b + a;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            TestClassNotStatic testClassNotStatic = new TestClassNotStatic();
            MyDel myDel = new MyDel(TestClass.TestMethod);
            MyDel myDelNotStatic = new MyDel(testClassNotStatic.TestMethod);
            Console.WriteLine(myDel(179, 57));
            Console.WriteLine(myDelNotStatic(179, 57));
            MyDel myDelAll = new MyDel(TestClass.TestMethod);
            myDelAll += testClassNotStatic.TestMethod;
            Console.WriteLine(myDelAll(57, 179));
        }
    }
}