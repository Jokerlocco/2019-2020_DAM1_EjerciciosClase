/*
CONTACT WITH CLASSES - 01
 
Create a class called "Title."

Its (public) attributes will be the text and the x and y coordinates.

It will have a method called "Display", which will display the text on 
the screen, at its coordinates.

Create a "TitleTest" class with a "Main" to test it.
*/

using System;

class Title
{
    public int x;
    public int y;
    public string text;

    public void Display()
    {
        Console.SetCursorPosition(x, y);
        Console.Write(text);
    }
}


class TitleTest
{
    static void Main()
    {
        Title t = new Title();
        t.x = 35;
        t.y = 10;
        t.text = "Hello";

        t.Display();
    }
}

