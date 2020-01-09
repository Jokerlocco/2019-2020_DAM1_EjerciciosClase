// DemoScreen
// Part of ConsolePhoenix

// Version    Date     By + Changes
// -------  --------  ------------------------------------
//  0.04     09-01-20  Nacho: A very simple animation
//  0.02     08-01-20  Nacho: Displays some text
//  0.01     08-01-20  Nacho: Empty skeleton

using System;
using System.Threading;

class DemoScreen
{
    public void Run()
    {
        int frame = 0;
        do
        {
            Console.Clear();
            Console.WriteLine("Demo");
            Console.SetCursorPosition(frame, 1);
            Console.WriteLine("-");

            Console.SetCursorPosition(0, 20);
            Console.Write("Check back soon... ");
            Thread.Sleep(100);
            frame++;
            if (frame >= 5) frame = 0;
        }
        while (!Console.KeyAvailable);
        Console.ReadKey(true);
    }
}
