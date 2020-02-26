// Text file to simple HTML
// Version 2: StreamReader + StreamWriter, constructors

using System;
using System.IO;

public class TxtToUpper2
{
    public static void Main()
    {
        Console.Write("Enter the file name: ");
        string name = Console.ReadLine();
        StreamReader input = new StreamReader(name);
        StreamWriter output = new StreamWriter( name + ". html");
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
