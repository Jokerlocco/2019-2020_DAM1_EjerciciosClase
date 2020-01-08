using System;

class Game
{
    public void Run()
    {
        Spaceship ship = new Spaceship();
        while (true)  //   ;-)
        {
            ship.Draw();
            string key = Console.ReadLine();
            switch (key)
            {
                case "a": ship.MoveLeft(); break;
                case "d": ship.MoveRight(); break;
                case "esc": return;
            }
        }
    }
}

