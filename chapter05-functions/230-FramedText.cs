// Pablo Vigara Fernández
// TextFramed

using System;

class TextFramed
{
    static void DisplayTextFramed(string text)
    {
        int length = text.Length;
        Console.Write("+");
        for (int i = 0; i < length + 4; i++)
        {
            Console.Write("-");
        }
        Console.WriteLine("+");
        
        Console.Write("|  ");
        Console.Write(text);
        Console.WriteLine("  |");
        
        Console.Write("+");
        for (int i = 0; i < length + 4; i++)
        {
            Console.Write("-");
        }
        Console.WriteLine("+");
    }
    
    static void Main ()
    {
        DisplayTextFramed("Hola");
    }
}
