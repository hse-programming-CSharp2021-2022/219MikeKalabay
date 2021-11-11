using System;
// Простите, что суток просрочился :(
namespace Task01
{
    class VideoFile
    {
        public VideoFile(string name, int duration, int quality)
        { string_name = name; int_duration = duration; int_quality = quality; }
        private string string_name { get; }
        private int int_duration { get; }
        private int int_quality { get; }
        public int Size()
        { return int_duration * int_quality; }
        public string GetInfo()
        { return $"name: {string_name} duration: {int_duration} " +
                $"quality {int_quality} size: {Size()}"; }
    }

    class Program
    {
        public static string GetName()
        {
            Random rand = new Random();
            int len = rand.Next(2, 9);
            string res = "";
            for (int i = 0; i < len; ++i)
            {
                res += (char)((int)'a' + rand.Next(0, 'z' - 'a'));
            }
            return res;
        }

        public static int GetDuration()
        {
            Random rand = new Random();
            return rand.Next(60, 360);
        }

        public static int GetQuality()
        {
            Random rand = new Random();
            return rand.Next(100, 1000);
        }

        public static void Main(string[] args)
        {
            do {
                // Console.WriteLine("Hello World!");
                Random rand = new Random();
                VideoFile videoFile = new VideoFile(GetName(), 
                    GetDuration(), GetQuality());
                Console.WriteLine("данные:");
                Console.WriteLine(videoFile.GetInfo());
                int n = rand.Next(5, 15);
                Console.WriteLine(n);
                VideoFile[] videoFiles = new VideoFile[n];
                for (int i = 0; i < n; ++i)
                {
                    videoFiles[i] = new VideoFile(GetName(),
                        GetDuration(), GetQuality());
                    Console.WriteLine(videoFiles[i].GetInfo());
                }
                Console.WriteLine("ответ:");
                for (int i = 0; i < n; ++i)
                {
                    if (videoFiles[i].Size() > videoFile.Size())
                    {
                        Console.WriteLine(videoFiles[i].GetInfo());
                    }
                }
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}