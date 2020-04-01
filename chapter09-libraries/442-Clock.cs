//Daniel García

using System;
using System.Threading;

class Clock
{
    static void Main(string[] args)
    {
        Console.SetWindowSize(80,25);
        Console.BackgroundColor = ConsoleColor.Blue;
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Clear();
        while (true)
        {
            Console.SetCursorPosition(70, 0);
            DateTime date = DateTime.Now;
            Console.WriteLine("{0}:{1}:{2}",
                date.Hour.ToString("00"), 
                date.Minute.ToString("00"), 
                date.Second.ToString("00"));
            Thread.Sleep(1000);
        }
    }
}
