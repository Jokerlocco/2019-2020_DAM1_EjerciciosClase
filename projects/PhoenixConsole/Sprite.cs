using System;

class Sprite
{
    protected int x;
    protected int y;
    protected char symbol;

    public void Draw()
    {
        Console.SetCursorPosition(x, y);
        Console.Write(symbol);
    }
}
