using System;

class StringContains
{
    static bool Contains(string text, char c)
    {
        // Base case
        if (text == "")
            return false;

        // General case
        if (text[0] == c)
            return true;
        return Contains(text.Substring(1), c);
    }

    static void Main()
    {
        if (Contains("Hola", 'a'))
            Console.WriteLine("Hola contains an a");
    }
}
