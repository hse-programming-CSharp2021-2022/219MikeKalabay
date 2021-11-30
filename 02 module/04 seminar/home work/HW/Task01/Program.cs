using System;

namespace Task01
{
    // Сиквел.
    // Разработчики из HSE company просят доработать ваше приложение!
    // Дело в том, что разработчики тоже ошибаются, и приходится откатывать приложение к предыдущей версии.
    // К тому же, HSE company не хочет расходовать много памяти,
    // поэтому было принято решение хранить только определенное колличество последних версий приложений (MaxCount).
    // 
    // На вход программе подаются запросы следующего типа:
    // 1) add <application_name> <version> - добавить актуальную версию приложения.
    // 2) back <application_name> - откатить приложение до предыдущей версии. Если предыдущей нет, то удалить приложение.
    // 3) get <application_name> - получить актуальную версию приложения. Если приложения нет, то сообщить об этом.
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
                Console.WriteLine("1) добавить актуальную версию приложения.");
                Console.WriteLine("2) откатить приложение до предыдущей версии.");
                Console.WriteLine("3) получить актуальную версию приложения.");
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
                        Console.WriteLine("Введите ключ.");
                        key = Console.ReadLine();
                        Console.WriteLine("Введите версию.");
                        version = Console.ReadLine();
                        RedisClient.Add(key, version);
                        break;
                    case 2:
                        Console.WriteLine("Введите ключ.");
                        key = Console.ReadLine();
                        Console.WriteLine(RedisClient.Back(key));
                        break;
                    case 3:
                        Console.WriteLine("Введите ключ.");
                        key = Console.ReadLine();
                        Console.WriteLine(RedisClient.Get(key));
                        break;
                    default:
                        checkEnd = true;
                        break;
                }
            }
        }
    }
}