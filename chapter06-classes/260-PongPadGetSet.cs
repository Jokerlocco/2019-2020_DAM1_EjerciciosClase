/*
Create getters and setters for the class "Pad"
*/

// Pablo Conde

using System;

class Pad
{
    private int x;
    private int y;
    private int speedY;
    
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
    
    public int GetSpeedY()
    {
        return speedY;
    }
    
    public void SetSpeedY(int newSpeedY)
    {
        speedY = newSpeedY;
    }
    

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
        Console.WriteLine( p.GetY() );
    }
}
