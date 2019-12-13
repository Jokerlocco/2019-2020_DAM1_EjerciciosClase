//DAVID BERENGUER ANTON

using System;

class Title
{
    protected string text;
    protected int x;
    protected int y;
    
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

class TitleCentered: Title
{
    public new void Display()
    {
        Console.SetCursorPosition(40 - text.Length/2, y);
        Console.WriteLine(text);
        Console.SetCursorPosition(40 - text.Length/2, y + 1);
        for (int i = 0; i < text.Length; i++)
        {
            Console.Write("-");
        }
        Console.WriteLine();
    }
}

class TitleUnderlined: Title
{
    public new void Display()
    {
        Console.SetCursorPosition(x, y);
        Console.WriteLine(text);
        Console.SetCursorPosition(x,y + 1);
        for (int i = 0; i < text.Length; i++)
        {
            Console.Write("-");
        }
        Console.WriteLine();
    }
}

class TitleTest
{
    static void Main()
    {
        TitleCentered myTitle = new TitleCentered();

        myTitle.SetY(5);
        myTitle.SetText("Hola, qué tal?");

        myTitle.Display();
    }
}
