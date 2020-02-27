// No redundant spaces
// Version 1a: StreamReader + StreamWriter, OpenText + CreateText

using System;
using System.IO;

public class NoRedundantSpaces
{
    public static void Main(string[] args)
    {
        if (args.Length < 1)
            return;

        string name = args[0];
        StreamReader input = File.OpenText(name);
        StreamWriter output = File.CreateText( name + ".nospc.txt");
        
        string line;
        int count = 1;
        do
        {
            line = input.ReadLine();
            if (line != null)
            {
                line = line.Trim();
                while (line.Contains("  "))
                    line = line.Replace("  ", " ");
                output.WriteLine(count + ". " + line);
                count++;
            }
        }
        while (line != null);
        
        output.Close();
        input.Close();
        Console.WriteLine("Redundant spaces removed");
    }
}
