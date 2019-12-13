/*
Sprite + Pad + Ball + Test
*/

using System;

class Sprite
{
    protected int x;
    protected int y;
    protected byte speedX;
    protected byte speedY;
    protected char symbol;

    public void Init()
    {
        symbol = '-';
    }


    public int GetX()
    {
        return x;
    }

    public void SetX(int newX)
    {
        x = newX;
    }

    public int GetY()
    {
        return y;
    }

    public void SetY(int newY)
    {
        y = newY;
    }

    public int GetSpeedX()
    {
        return speedX;
    }

    public void SetSpeedX(int newSpeedX)
    {
        speedX = (byte)newSpeedX;
    }

    public int GetSpeedY()
    {
        return speedY;
    }

    public void SetSpeedY(int newSpeedY)
    {
        speedY = (byte)newSpeedY;
    }
    public void Draw()
    {
        Console.SetCursorPosition(x, y);
        Console.WriteLine(symbol);
    }

}

// --------------------------------

class Ball : Sprite
{
    public new void Init()
    {
        symbol = 'O';
    }

    public void Move()
    {
        x += speedX;
        y += speedY;
    }
}

// --------------------------------

class Pad : Sprite
{
    public new void Init()
    {
        symbol = '|';
        speedX = 0;
    }

    public void MoveUp()
    {
        y -= speedY;
    }

    public void MoveDown()
    {
        y += speedY;
    }
}

// --------------------------------

class PadTest
{
    static void Main()
    {
        Pad p = new Pad();
        p.Init();
        //p.x = 20;
        p.SetX(30); //for Ruth
        //p.y = 5;
        p.SetY(5);
        //p.speedY = 1;
        p.SetSpeedY(1);
        p.Draw();

        Console.ReadLine();
        p.MoveDown();
        p.Draw();

        //Console.WriteLine( p.y );
        Console.WriteLine(p.GetY());
    }
}
