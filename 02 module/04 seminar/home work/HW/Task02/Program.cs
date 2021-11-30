using System;
using System.Collections.Generic;

namespace Task02
{
    // Сиквел.
    // У Склад.LIFE большое количество различных складов с различными видами товаров.
    // Руководству важно знать, какие виды товаров находятся на различных складах. Помогите Склад.LIFE. 
    // P.S. В последнее время с заказами все плохо, поэтому на склад только завозят новые виды товаров.
    //
    // На вход программе поступают следующие запросы:
    // 1) add <storage_name> <product_name> - добавить вид товара на склад.
    // 2) get <storage_name> - получить список всех видов товаров на складе.
    // 3) exist <storage_name> <product_name> - узнать находится ли вид товара на складе.
    // 4) exit - завершить программу.

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                RedisClient.Connect();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return;
            }

            bool checkEnd = false;
            while (!checkEnd)
            {
                Console.WriteLine("1) добавить вид товара на склад.");
                Console.WriteLine("2) получить список всех видов товаров на складе.");
                Console.WriteLine("3) узнать находится ли вид товара на складе.");
                Console.WriteLine("4) завершить программу.");
                Console.WriteLine("Введите номер.");
                string input = Console.ReadLine();
                int num;
                while (!int.TryParse(input, out num) || num > 4 || num < 1)
                {
                    Console.WriteLine("Некорректный ввод.");
                    Console.WriteLine("Введите номер.");
                    input = Console.ReadLine();
                }
                string key, version;
                switch (num)
                {
                    case 1:
                        Console.WriteLine("Введите склад.");
                        key = Console.ReadLine();
                        Console.WriteLine("Введите товар.");
                        version = Console.ReadLine();
                        RedisClient.Add(key, version);
                        break;
                    case 2:
                        Console.WriteLine("Введите склад.");
                        key = Console.ReadLine();
                        List<string> a = RedisClient.GetProducts(key);
                        foreach (string s in a)
                        {
                            Console.WriteLine(s);
                        }
                        break;
                    case 3:
                        Console.WriteLine("Введите склад.");
                        key = Console.ReadLine();
                        Console.WriteLine("Введите товар.");
                        version = Console.ReadLine();
                        if (RedisClient.ExistProduct(key, version))
                        {
                            Console.WriteLine("Есть на складе.");
                        }
                        else
                        {
                            Console.WriteLine("Нет на складе.");
                        }
                        break;
                    default:
                        checkEnd = true;
                        break;
                }
            }
        }
    }
}