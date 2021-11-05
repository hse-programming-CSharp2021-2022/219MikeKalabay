using System;
using System.Drawing;
public class ConsolePlate
{
    char _plateChar; // символ
    ConsoleColor _plateColor = ConsoleColor.White; // цвет символа
                                                   // конструкторы
    ConsoleColor _plateBackgroundColor = ConsoleColor.Black;
    public ConsolePlate()
    {
        _plateChar = 'A';
    }
    public ConsolePlate(char plateChar, ConsoleColor plateColor, ConsoleColor plateBackgroundColor)
    {
        this.PlateChar = plateChar; // используем свойства 
        this.PlateColor = plateColor;
        this.PlateBackgroundColor = plateBackgroundColor;
    }
    // Объявление свойств    

    public char PlateChar
    {
        set
        {
            if (value >= 65 && value <= 90) // отбрасываем командные символы
                _plateChar = value;
            else
                _plateChar = 'A';
        }
        get { return _plateChar; }
    }
    public ConsoleColor PlateColor
    {
        set { _plateColor = value; }
        get { return _plateColor; }
    }

    public ConsoleColor PlateBackgroundColor
    {
        set { _plateBackgroundColor = value; }
        get { return _plateBackgroundColor; }
    }

}
class Program
{
    static void Main()
    {
        Console.WriteLine("Не нашёл розового цвета.");
        ConsolePlate[] a = {new ConsolePlate('X', ConsoleColor.White, ConsoleColor.Red),
            new ConsolePlate('O', ConsoleColor.White, ConsoleColor.Yellow)};
        int n;
        int.TryParse(Console.ReadLine(), out n);
        int now;
        for (int i = 0; i < n; ++i)
        {
            now = i % 2;
            for (int j = 0; j < n; ++j)
            {
                Console.ForegroundColor = a[now].PlateColor;
                Console.BackgroundColor = a[now].PlateBackgroundColor;
                Console.Write(a[now].PlateChar);
                now = (now + 1) % 2;
            }
            Console.WriteLine();
        }
        Console.BackgroundColor = ConsoleColor.Black;
    }
}