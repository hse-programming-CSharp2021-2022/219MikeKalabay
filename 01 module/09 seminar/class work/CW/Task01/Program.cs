using System;
using System.Text;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split(';');
            string check = "AEUYIO";
            for (int i = 0; i < array.Length; ++i)
            {
                StringBuilder ans = new StringBuilder();
                string[] now = array[i].Split();
                for (int j = 0; j < now.Length; ++j)
                {
                    //далее лютая копипаста.
                    for (int q = 0; q < now[j].Length; ++q)
                    {
                        if (q == 0)
                        {
                            ans.Append(now[j][q].ToString().ToUpper());
                            bool flag = true;
                            for (int p = 0; p < 6; ++p)
                            {
                                if (now[j][q].ToString().ToUpper() == check[p].ToString())
                                {
                                    flag = false;
                                    break;
                                }
                            }
                            if (!flag)
                            {
                                break;
                            }
                        }
                        else {
                            bool flag = true;
                            for (int p = 0; p < 6; ++p)
                            {
                                if (now[j][q].ToString().ToUpper() == check[p].ToString())
                                {
                                    flag = false;
                                    break;
                                }
                            }
                            ans.Append(now[j][q].ToString().ToLower());
                            if (!flag)
                            {
                                break;
                            }
                        }
                    }
                }
                Console.WriteLine(ans);
            }
        }
    }
}
