using System;
using System.Text;

namespace Task01
{
    class Program
    {
        public static string ConvertHex2Bin(string HexNumber)
        {
            StringBuilder ans = new StringBuilder();
            for (int i = 0; i < HexNumber.Length;  ++i)
            {
                int now = 0;
                if (HexNumber[i] >= '0' && HexNumber[i] <= '9')
                {
                    now = HexNumber[i] - '0';
                }
                else
                {
                    now = 10 + (HexNumber[i] - 'A');
                }
                for (int j = 3; j >= 0; --j)
                {
                    if (((1 << j) & now) != 0)
                    {
                        ans.Append('1');
                    }
                    else
                    {
                        ans.Append('0');
                    }
                }
            }
            return ans.ToString();
        }

        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            Console.WriteLine(ConvertHex2Bin(s));
        }
    }
}
