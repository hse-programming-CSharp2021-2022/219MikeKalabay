using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            Regex regex = new Regex(@"\b\[a-zA-z]{4}\b");
            // \b[a-zA-Z]*a\b
            // [0-9]+
            var matches = regex.Matches(s);

            foreach (Match m in matches)
            {
                Console.WriteLine(m);
            }
        }
    }
}