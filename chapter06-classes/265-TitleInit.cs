// Title Class + Init

/*
Create an Init method for the "Title" class, which will allow you to set 
starting values for x, y, text.

Try it from "Main" with the values: text = "Hello", x = 40, y = 10
*/

using System;

class Title
{
    string text;
    int x;
    int y;
    
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
