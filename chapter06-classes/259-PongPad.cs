/*
Create a class called "Pad", which will contain part of what 
is expected in Pong's pads.

Its (public) attributes will be the x and y coordinates, and 
the Y speed.

It will have a method called "Draw", which will show the pad on the 
screen, at the coordinates indicated by the attributes, and methods 
"Move Up" and "Move Down".

Create a "PadTest" class with a "Main" to test it.
*/

using System;

class Pad
{
    public int x;
    public int y;
    public int speedY;

    public void Draw()
    {
        Console.SetCursorPosition(x, y);
        Console.WriteLine("|");
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

class PadTest
{
    static void Main()
    {
        Pad p = new Pad();
        p.x = 20;
        p.y = 5;
        p.speedY = 1;
        p.Draw();

        Console.ReadLine();
        b.MoveDown();
        b.Draw();
    }
}
