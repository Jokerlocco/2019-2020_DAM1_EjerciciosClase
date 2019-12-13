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

class TitleUnderlined : Title
{
    public new void Display()
    {
        Console.SetCursorPosition(x, y);
        Console.WriteLine(text);
        Console.SetCursorPosition(x, y+1);
        for (int i = 0; i < text.Length; i++)
            Console.Write("_");
    }
}

class TitleTest
{
    static void Main()
    {
        TitleUnderlined myTitle = new TitleUnderlined();

        Console.Write("Enter X: ");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Y: ");
        int y = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter text: ");
        string t = Console.ReadLine();

        myTitle.SetX(x);
        myTitle.SetY(y);
        myTitle.SetText(t);
        myTitle.Display();

        Title mySecondTitle = new Title();
        mySecondTitle.SetX(x+2);
        mySecondTitle.SetY(y+3);
        mySecondTitle.SetText(t);
        mySecondTitle.Display();
    }
}
