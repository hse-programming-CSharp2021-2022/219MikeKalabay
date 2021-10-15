using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] names = {"A", "", "", ""};
            //var selected2 = from t in names select t;
            string s = "Бык тупогуб, тупогубенький бычок, у быка бела губа тупа.";
            Regex regex = new Regex("туп");
            var matches = regex.Matches(s);

            foreach (Match m in matches)
            {
                Console.WriteLine(m);
            }

            regex = new Regex(@"туп\w*");
            matches = regex.Matches(s);

            foreach (Match m in matches)
            {
                Console.WriteLine(m);
            }
        }
    }
}
