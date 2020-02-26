// Text file to simple HTML
// Version 3: ReadAllText + WriteAllText

using System;
using System.IO;

public class TxtToUpper3
{
    public static void Main()
    {
        Console.Write("Enter the file name: ");
        string name = Console.ReadLine();

        string text = File.ReadAllText(name);
        text = text.Replace("\n\n", "\n</p><p>\n");
        File.WriteAllText(name + ".html",
            "<html><p>" + text + "</p></html>");

        Console.WriteLine("Simple HTML generated");
    }
}
