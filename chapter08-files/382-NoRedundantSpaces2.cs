// Pablo Vigara Fernandez

// No redundant spaces
// Version 2: ReadAllLines + WriteAllLines


using System;
using System.IO;

public class NoRedundantSpaces
{
    static void Main(string[] args)
    {
        if (args.Length < 1)
            return;

        string name = args[0];
        string[] content = File.ReadAllLines(name);
        for (int i = 0; i < content.Length; i++)
        {
            content[i] = content[i].Trim();

            while (content[i].Contains("  "))
                content[i] = content[i].Replace("  ", " ");

            content[i] = (i+1) + ". " + content[i];
        }

        File.WriteAllLines(name + ".nospc.txt", content);
        Console.WriteLine("Redundant spaces removed");
    }
}
