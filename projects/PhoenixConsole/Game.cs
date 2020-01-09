using System;

class Game
{
    public void Run()
    {
        ConsoleKeyInfo userkey;
        Spaceship ship = new Spaceship();
        while (true)
        {
            Console.Clear();
            ship.Draw();
            userkey = Console.ReadKey(true);
            switch (userkey.Key)
            {
                case ConsoleKey.A: ship.MoveLeft(); break;
                case ConsoleKey.D: ship.MoveRight(); break;
                case ConsoleKey.Escape: return;

            }
        }

    }
}
