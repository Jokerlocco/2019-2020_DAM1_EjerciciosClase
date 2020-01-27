//Abraham García

using System;
using System.Threading;

class Aquarium
{   
    static void Main()
    {
        Console.SetWindowSize(80, 25);
        Console.SetBufferSize(80, 25);
        Console.BackgroundColor = ConsoleColor.DarkCyan;

        Intro intro = new Intro();
        intro.Launch();
    }
}

// ---------------------

abstract class Sprite
{
    public int X { get; set; }
    public int Y { get; set; }
    public int SpeedX { get; set; }
    public int SpeedY { get; set; }

    public Sprite(int x, int y)
    {
        X = x;
        Y = y;
        SpeedX = 1;
        SpeedY = 1;
    }

    public virtual void Draw(int x, int y)
    {
        Console.SetCursorPosition(x, y);
    }

    public virtual void Move()
    {
        X -= SpeedX;
        Y -= SpeedY;
    }
}

// ---------------------

sealed class Intro
{
    public int borderLeft = 2;
    public int borderRight = 80;
    public int borderTop = 2;
    public int borderBottom = 25;

    public int amountBubble = 0;
    public bool[] launchBubble = new bool[5];

    public void Launch()
    {
        Fish fish = new Fish(20, 8);

        Seaweed[] sw = new Seaweed[6];
        for (int i = 0; i < 6; i++)
        {
            if (i % 2 == 0)
                sw[i] = new SeaweedLong((13 * i + 5), 16);
            else
                sw[i] = new SeaweedShort((13 * i + 5), 21);
        }

        Bubble bubbleFish = new Bubble(fish.X, fish.Y);
        Bubble[] bubbleBackground = new Bubble[5];
        for (int i = 0; i < 5; i++)
            bubbleBackground[i] = new Bubble(20, 24);

        Settings.RealSpeed = 10;
        Settings.ConsoleSpeed = 100;

        while (true)
        {
            Settings.UpdateScreenAndTimer();

            //********* Background bubbles ************
            if (Settings.Timer % 5 == 0)
            {
                launchBubble[amountBubble] = true;
                if (amountBubble < 4)
                    amountBubble++;
                else
                    amountBubble = 0;
            }
            int r = new Random().Next(0, 70);
            for (int i = 0; i < 5; i++)
            {
                if (launchBubble[i])
                    bubbleBackground[i].MoveUp(r, 24, ConsoleColor.Blue);
            }

            //**************** Fish *******************
            fish.Draw(fish.X, fish.Y);
            fish.Move();
            if (fish.X <= borderLeft || fish.X >= borderRight - 13)
            {
                fish.SpeedX = -fish.SpeedX;
                fish.TurnFish = fish.TurnFish ? fish.TurnFish = false : fish.TurnFish = true;
            }

            if (fish.Y <= borderTop + 4 || fish.Y >= borderBottom - 16)
                fish.SpeedY = -fish.SpeedY;

            if (!fish.TurnFish)
                bubbleFish.MoveUp(fish.X, fish.Y + 3, ConsoleColor.Cyan);
            else
                bubbleFish.MoveUp(fish.X + 12, fish.Y + 3, ConsoleColor.Cyan);

            if (Settings.Timer % 5 == 0)
                fish.eyeClosed = fish.eyeClosed ? fish.eyeClosed = false : fish.eyeClosed = true;

            //*************** Seaweeds *****************

            foreach (Seaweed seaweed in sw)
                seaweed.Draw(seaweed.X, seaweed.Y);

            Thread.Sleep(Settings.ConsoleSpeed);
        }
    }
}



// ---------------------

class Bubble : Sprite
{
    public bool ActivateBubble { get; set; }

    public Bubble(int x, int y)
        : base(x, y)
    {
    }

    public void MoveUp(int x, int y, ConsoleColor c)
    {
        if (ActivateBubble)
        { 
            Y -= SpeedY;
            Console.ForegroundColor = c;
            Console.SetCursorPosition(X, Y);
            Console.Write("O");
        }
        else
        {
            X = x;
            Y = y;
            ActivateBubble = true;
        }

        if (Y <= 1)
            ActivateBubble = false;
            
    }
}

// ---------------------

class Fish : Sprite
{
    public bool TurnFish { get; set; }
    public bool eyeClosed { get; set; }

    public Fish(int x, int y)
        : base (x, y)
    {
    }

    public override void Draw(int x, int y)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;

        byte[] n = new byte[5];
        if (!TurnFish)
        {
            n[0] = 3; n[1] = 8; n[2] = 2; n[3] = 11; n[4] = 8;
        }
        else
        {
            n[0] = 10;  n[1] = 6; n[2] = 3; n[3] = 12; n[4] = 6;
        }

            for (int i = 1; i <= 7; i++)
            {
                base.Draw(x, y + i);
                for (int j = 1; j <= 13; j++)
                {
                    if (i == 4 && j == n[0])
                    {
                        if (eyeClosed)
                            Console.Write("_");
                        else
                            Console.Write("o");
                    }  
                    else if ((i == 1 && j == n[1]) ||
                        ((i == 2 || i == 6 ) && (j >= 6 && j <= 8)) ||
                        ((i == 3 || i == 5 ) && (j >= n[2] && j <= n[3])) ||
                        (i == 4 && (j >= 1 && j <= 13)) ||
                        (i == 7 && j == n[4]))
                        Console.Write("#");
                    else
                        Console.Write(" ");
                }
            }
    }
}


// ---------------------

abstract class Seaweed : Sprite
{
    public Seaweed(int x, int y)
         : base(x, y)
    {
    }

    public override void Draw(int x, int y)
    {
        base.Draw(x, y);
        Console.ForegroundColor = ConsoleColor.Green;
    }
}

// ---------------------

class SeaweedLong : Seaweed
{
    public SeaweedLong(int x, int y)
         : base(x, y)
    {
    }

    public override void Draw(int x, int y)
    {
        for (int i = 1; i <= 8; i++)
        {
            base.Draw(x, y + i);
            for (int j = 1; j <= 9; j++)
            {
                if (((i == 1 || i == 2 || i == 3) && (j == 5)) ||
                    (i == 4 && (j == 5 || j == 9)) ||
                    (i == 5 && (j == 1 || j == 5 || j == 9)) ||
                    (i == 6 && (j == 1 || j == 2 || j == 5 || j == 6 || j == 9)) ||
                    (i == 7 && (j == 2 || j == 3 || j == 5 || j == 7)) ||
                    (i == 8 && (j >= 3 && j <= 6)))
                    Console.Write("*");
                else
                    Console.Write(" ");
            }
        }
    }
}

// ---------------------

class SeaweedShort : Seaweed
{
    public SeaweedShort(int x, int y)
         : base(x, y)
    {
    }

    public override void Draw(int x, int y)
    {
        for (int i = 1; i <= 3; i++)
        {
            base.Draw(x, y + i);
            for (int j = 1; j <= 7; j++)
            {
                if ((i == 1 && (j == 1 || j == 4 || j == 7)) ||
                    (i == 2 && (j == 2 || j == 4 || j == 6)) ||
                    (i == 3 && (j >= 3 && j <= 5)))
                    Console.Write("*");
                else
                    Console.Write(" ");
            }        
        }
    }
}

// ---------------------

sealed class Settings
{
    public static int Timer { get; set; }
    public static int RealSpeed { get; set; }
    public static int ConsoleSpeed { get; set; }

    public static ConsoleKeyInfo userkey;

    public static void UpdateScreenAndTimer()
    {
        Timer++;
        Console.Clear();
        Console.SetCursorPosition(1, 1);
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Write("Speed: " + RealSpeed +
            "  (UpKey to speed up / DownKey to speed down)");

        if (Console.KeyAvailable)
        {
            userkey = Console.ReadKey();
            if (userkey.Key == ConsoleKey.UpArrow && ConsoleSpeed > 0)
            {
                ConsoleSpeed -= 10;
                RealSpeed++;
            }
            if (userkey.Key == ConsoleKey.DownArrow && ConsoleSpeed < 190)
            {
                ConsoleSpeed += 10;
                RealSpeed--;
            }
        }
    }
}
