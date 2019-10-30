// Versión  Fecha     Por + cambios
// -------  --------  ------------------------------------
// 0.03     18-10-19  Cristina Francés: Bat can be moved with WS (no Return)
// 0.02     17-10-19  Nacho: Bat can be moved with WS (+Return)
// 0.01     17-10-19  Joel Martinez: Display a bat

using System;

class Pong
{
    static void Main()
    {
        int y = 12;
        ConsoleKeyInfo userkey;
        do
        {
            Console.Clear();
            Console.SetCursorPosition(77, y);
            Console.Write("|");
            Console.SetCursorPosition(1, 1);

            userkey = Console.ReadKey(true);

            if (userkey.Key == ConsoleKey.W)
                y--;
            if (userkey.Key == ConsoleKey.S)
                y++;
        }
        while (userkey.Key != ConsoleKey.P);
    }

}
