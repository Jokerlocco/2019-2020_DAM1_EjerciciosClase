// Text file to simple HTML
// Version 1: StreamReader + StreamWriter, OpenText + CreateText

using System;
using System.IO;

public class TxtToUpper1a
{
    public static void Main()
    {
        Console.Write("Enter the file name: ");
        string name = Console.ReadLine();
        StreamReader input = File.OpenText(name);
        StreamWriter output = File.CreateText( name + ". html");
        output.WriteLine("<html><p>");
        
        string line;
        do
        {
            line = input.ReadLine();
            if (line != null)
            {
                if (line.Trim() != "")
                    output.WriteLine(line);
                else
                    output.WriteLine("</p><p>");
            }
        }
        while (line != null);
        
        output.WriteLine("</p></html>");
        output.Close();
        input.Close();
        Console.WriteLine("Simple HTML generated");
    }
}
