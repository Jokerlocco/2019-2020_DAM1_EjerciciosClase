// Title Class + Destructor

using System;

class Title
{
    private string text;
    private int x;
    private int y;

    public Title()
    {
        x = 40;
        y = 12;
        text = "Welcome!!!";
    }

    public Title(int newX, int newY, string newText)
    {
        x = newX;
        y = newY;
        text = newText;
    }

    ~Title()
    {
        Console.WriteLine("Bye!");
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
        Title myTitle = new Title(5, 5, "Hi!");
        myTitle.Display();
    }
}
