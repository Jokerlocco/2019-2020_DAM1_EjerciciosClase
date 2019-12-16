// Title Class + Init (V2)

/*

Create a second Init method for the "Title" class, which will assign 
default initial values for x, y, text.

*/

using System;

class Title
{
    private string text;
    private int x;
    private int y;
    
    public void Init()
    {
        x = 40;
        y = 12;
        text = "Welcome!!!";
    }
    
    public void Init(int newX, int newY, string newText)
    {
        x = newX;
        y = newY;
        text = newText;
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

    public string GetText()
    {
        return text;
    }

    public void SetText(string newText)
    {
        text = newText;
    }

    public void Display()
    {
        Console.SetCursorPosition(x, y);
        Console.WriteLine(text);
    }
}

class TitleTest
{
    static void Main()
    {
        Title myTitle = new Title();

        myTitle.Init(30, 12, "Hola");
        myTitle.Display();
    }
}
