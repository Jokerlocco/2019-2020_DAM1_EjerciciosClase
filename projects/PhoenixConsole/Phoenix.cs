// Phoenix (launcher)
// Part of ConsolePhoenix

// Version    Date     By + Changes
// -------  --------  ------------------------------------
//  0.04     09-01-20  Nacho: Constants MAXX and MAXY
//  0.01     08-01-20  Nacho: Empty skeleton

using System;

class Phoenix
{
    public const int MAXX = 79;
    public const int MAXY = 24;

    static void Main()
    {
        Console.SetWindowSize(MAXX + 1, MAXY + 1);
        Console.SetBufferSize(MAXX + 1, MAXY + 1);
        Console.Title = "Phoenix";

        WelcomeScreen ws = new WelcomeScreen();
        ws.Run();
    }
}
