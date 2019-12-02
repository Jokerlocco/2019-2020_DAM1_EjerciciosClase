using System;

class Centered
{
    static void DisplayCentered(string text)
    {
        int screenWidth = 80;
        int halfScreen = screenWidth / 2;
        int spaces = halfScreen - text.Length / 2;
        for (int i = 0; i < spaces; i++) Console.Write(" ");
        Console.WriteLine(text);
    }

    static void Main()
    {
        DisplayCentered("Hello");
    }
}
