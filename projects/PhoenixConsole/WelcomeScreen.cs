

using System;

class WelcomeScreen
{
    public void Run()
    {
        Console.WriteLine("Welcome!");

        Console.WriteLine("1- Game");
        Console.WriteLine("2- Help");
        Console.WriteLine("3- Demo");
        Console.WriteLine("ESC- Quit");

        string option = Console.ReadLine();
        switch (option)
        {
            case "1": Game g = new Game(); g.Run(); break;
            case "2": HelpScreen h = new HelpScreen(); h.Run(); break;
            case "3": DemoScreen d = new DemoScreen(); d.Run(); break;
        }
    }
}
