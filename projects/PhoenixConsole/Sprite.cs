// Sprite
// Part of ConsolePhoenix

// Version    Date     By + Changes
// -------  --------  ------------------------------------
//  0.04     09-01-20  Nacho: Empty constructors, destroy; virtual Update
//  0.01     08-01-20  Nacho: Empty skeleton
//  0.01     08-01-20  Nacho: Empty skeleton

using System;

class Sprite
{
    protected int x;
    protected int y;
    protected char symbol;
    protected bool alive;

    public Sprite()
    {
        // TO DO: Destroy when all other constructors are ready
    }

    public Sprite(int x, int y, char symbol)
    {
        // TO DO: set attributes
        alive = true;
    }

    public void Destroy()
    {
        alive = false;
    }

    public virtual void Draw()
    {
        Console.SetCursorPosition(x, y);
        Console.Write(symbol);
    }

    public virtual void Update()
    {
    }
}