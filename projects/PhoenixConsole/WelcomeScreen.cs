// WelcomeScreen
// Part of ConsolePhoenix

// Version    Date     By + Changes
// -------  --------  ------------------------------------
//  0.03     09-01-20  ???: Menu uses ReadKey
//  0.02     08-01-20  Nacho: Simple menu
//  0.01     08-01-20  Nacho: Empty skeleton

using System;
class WelcomeScreen
{
    public void Run()
    {
        Console.WriteLine("Welcome");
        Console.WriteLine("1-Game");
        Console.WriteLine("2-Help");
        Console.WriteLine("3-Demo");
        Console.WriteLine("ESC-Quit");
        ConsoleKeyInfo key = Console.ReadKey(); 
        switch(key.Key)
        {
            case ConsoleKey.D1: Game g = new Game(); g.Run(); break;
            case ConsoleKey.D2: HelpScreen h = new HelpScreen(); h.Run(); break;
            case ConsoleKey.D3:DemoScreen d = new DemoScreen(); d.Run(); break;
        }
    }
    
}

