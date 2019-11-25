using System;

class FunctionWriteInverted2
{
    static void WriteInverted(string text)
    {
        string inverted = "";
        for (int i = text.Length-1; i >= 0; i--)
        {
            inverted += text[i];
        }
        Console.WriteLine(inverted);
    }

    public static void Main()
    {
        WriteInverted("Hola");
    }
}
