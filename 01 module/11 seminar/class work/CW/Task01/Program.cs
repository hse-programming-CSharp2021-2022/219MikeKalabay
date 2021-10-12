using System;
using System.IO;
using System.Text;

namespace ConsoleApp23
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"Data.txt";

            // Создаем файл с данными
            if (true)
            {
                int n = int.Parse(Console.ReadLine());
                // Сейчас данные для записи вбиты в коде
                // TODO1: сохранить в файл целые случайные значения из диапазона [10;100)
                var rand = new Random();
                int[] a = new int[n];
                for (int i = 0; i < n; ++i)
                {
                    a[i] = rand.Next(10, 99);
                }
                string createText = "";
                for (int i = 0; i < n; i += 5)
                {
                    for (int j = 0; j < 5; ++j)
                    {
                        if (i + j >= n)
                        {
                            break;
                        }
                        createText += a[i + j] + " ";
                        Console.Write(a[i + j] + " ");
                    }
                    createText += Environment.NewLine;
                    Console.WriteLine();
                }
                File.WriteAllText(path, createText, Encoding.UTF8);
            }

            // Open the file to read from
            if (File.Exists(path))
            {
                string readText = File.ReadAllText(path);
                string[] stringValues = readText.Split(' ');
                int[] arr = StringArrayToIntArray(stringValues);
                foreach (int i in arr)
                {
                    Console.Write(i + " ");
                }
                int[] arr1 = new int[0];
                int[] arr2 = new int[0];
                for (int i = 0; i < arr.Length; ++i)
                {
                    if (arr[i] % 2 == 0)
                    {
                        Array.Resize(ref arr1, arr1.Length + 1);
                        arr1[arr1.Length - 1] = i;
                    }
                    else
                    {
                        Array.Resize(ref arr2, arr2.Length + 1);
                        arr2[arr2.Length - 1] = i;
                    }
                }
                for (int i = 0; i < arr2.Length; ++i)
                {
                    arr[arr2[i]] = 0;
                }
                for (int i = 0; i < arr1.Length; ++i)
                {
                    Console.Write(arr1[i] + " ");
                }
                Console.WriteLine();
                for (int i = 0; i < arr2.Length; ++i)
                {
                    Console.Write(arr2[i] + " ");
                }
                Console.WriteLine();
                for (int i = 0; i < arr.Length; ++i)
                {
                    Console.Write(arr[i] + " ");
                }
                Console.WriteLine();
                // обрабатываем элементы массива
                // TODO2: Создать два массива по исходному
                // в первый поместить индексы чётных элементов, во второй - нечётных
                // TODO3: Заменяем все нечётные числа исходного массива нулями
            }
        } // end of Main()
        // преобразование массива строк в массив целых чисел
        public static int[] StringArrayToIntArray(string[] str)
        {
            int[] arr = null;
            if (str.Length != 0)
            {
                arr = new int[0];
                foreach (string s in str)
                {
                    int tmp;
                    if (int.TryParse(s, out tmp))
                    {
                        Array.Resize(ref arr, arr.Length + 1);
                        arr[arr.Length - 1] = tmp;
                    }
                } // end of foreach (string s in str)      
            }
            return arr;
        } // end of StringToIntArray()
    } // end of Program
}
