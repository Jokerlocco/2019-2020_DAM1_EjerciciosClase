// Versión  Fecha     Por + cambios
// -------  --------  ------------------------------------
// 0.05     06-11-19  Nacho: Moving ball
// 0.04     25-10-19  Nacho: Changing colors
// 0.03     18-10-19  Cristina Francés: Bat can be moved with WS (no Return)
// 0.02     17-10-19  Nacho: Bat can be moved with WS (+Return)
// 0.01     17-10-19  Joel Martinez: Display a bat

using System;
using System.Threading;

class Pong
{
    static void Main()
    {
        int y = 12;
        int xBall = 20, yBall = 5;
        bool finished = false;
        ConsoleKeyInfo userkey;
        do
        {
            Console.Clear();

            Console.SetCursorPosition(37, y);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("|");

            Console.SetCursorPosition(xBall, yBall);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("O");

            Console.SetCursorPosition(1, 1);

            if (Console.KeyAvailable)
            {
                userkey = Console.ReadKey(true);

                if (userkey.Key == ConsoleKey.W)
                    y--;
                if (userkey.Key == ConsoleKey.S)
                    y++;

                if (userkey.Key == ConsoleKey.Escape)
                    finished = true;
            }

            xBall++;
            yBall++;
            Thread.Sleep(200);
        }
        while ( ! finished );

        Console.ForegroundColor = ConsoleColor.White;
    }
}
