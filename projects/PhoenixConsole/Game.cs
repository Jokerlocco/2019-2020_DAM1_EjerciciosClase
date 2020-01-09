// Game
// Part of ConsolePhoenix

// Version    Date     By + Changes
// -------  --------  ------------------------------------
//  0.04     09-01-20  Nacho: Added most classes for testing purposes
//  0.02     09-01-20  ???: Checking keys, using ReadKey
//  0.02     08-01-20  Nacho: Checking keys, using ReadLine
//  0.01     08-01-20  Nacho: Empty skeleton

using System;

class Game
{
    public void Run()
    {
        const int NUM_ENEMIES = 4;
        ConsoleKeyInfo userkey;

        Spaceship ship = new Spaceship();
        MovingBackground back = new MovingBackground();
        Scoreboard sb = new Scoreboard();
        Enemy[] enemies = new Enemy[NUM_ENEMIES];
        enemies[0] = new EnemyLevel1();
        enemies[1] = new EnemyLevel2();
        enemies[2] = new EnemyLevel3();
        enemies[3] = new EnemyLevel4();
        Mothership ms = new Mothership();
        PlayerShot shot1 = new PlayerShot(20, 10);
        EnemyShot shot2 = new EnemyShot(15, 1);

        while (true)
        {
            // Update elements position and appearance
            back.Update();
            ms.Update();
            ship.Update();
            foreach (Enemy e in enemies) e.Update();
            shot1.Update();
            shot2.Update();

            // Screen update
            Console.Clear();
            back.Draw();
            sb.Draw();
            ms.Draw();
            ship.Draw();
            foreach (Enemy e in enemies) e.Draw();
            shot1.Draw();
            shot2.Draw();

            // Get user input
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
