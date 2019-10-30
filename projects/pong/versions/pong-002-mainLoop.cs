// Versión  Fecha     Por + cambios
// -------  --------  ------------------------------------
// 0.02     17-10-19  Nacho: Bat can be moved with WS (+Return)
// 0.01     17-10-19  Joel Martinez: Display a bat

using System;

class Pong
{
    static void Main()
    {
        int y = 12;
        string key;
        do
        {
            Console.Clear();
            Console.SetCursorPosition(77, y);
            Console.Write("|");
            Console.SetCursorPosition(1, 1);
            key = Console.ReadLine();
            if (key == "w")
                y--;
            if (key == "s")
                y++;
        }
        while (key != "p");
    }

}
