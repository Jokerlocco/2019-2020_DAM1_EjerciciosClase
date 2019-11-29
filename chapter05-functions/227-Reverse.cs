using System;

class StringReverse
{
    static string Reverse(string text)
    {
        // Base case
        if (text.Length == 0)
            return "";

        // General case
        return Reverse(text.Substring(1)) + text[0];

        /*
        Alternative way:
        return 
            text[ text.Length - 1] +
            Reverse(text.Substring(0, text.Length - 1));
        */
    }

    static void Main()
    {
        Console.WriteLine(Reverse("Hola Kiko"));
    }
}
