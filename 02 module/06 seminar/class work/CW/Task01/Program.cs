using System;

class Program
{
    static void Main()
    {
        try
        {
            // какой-то код
        }
        catch (ApplicationException e)
        {
            Console.Write(e.Message);
        }
        catch (SystemException e)
        {
            Console.Write(e.Message);
        }
        catch
        {
            Console.Write("что-то другое");
        }
    }
}