/*
Change the "y speed" for a pad to byte data type
*/

using System;

class Pad
{
    private int x;
    private int y;
    private byte speedY;
    
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
        speedY = (byte) newSpeedY;
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
