//Abraham García - Title Class (Getters/Setters)

/*
Create a new version of the "Title" class.

Its attributes will be private and it will have getters and setters.

Change the program and "Main" as necessary.
*/

using System;

class Title
{
    string text;
    int x;
    int y;

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

        Console.Write("Enter X: ");
        myTitle.SetX(Convert.ToInt32(Console.ReadLine()));
        Console.Write("Enter Y: ");
        myTitle.SetY(Convert.ToInt32(Console.ReadLine()));
        Console.Write("Enter text: ");
        myTitle.SetText(Console.ReadLine());

        myTitle.Display();
    }
}
