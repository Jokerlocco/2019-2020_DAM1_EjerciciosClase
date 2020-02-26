//DAVID BERENGUER ANTON

using System;

// Text file to simple HTML
// Version 4: ReadAllLines + WriteAllLines

using System;
using System.Collections.Generic;
using System.IO;

public class TxtToUpper4
{
    public static void Main()
    {
        Console.Write("Enter the file name: ");
        string name = Console.ReadLine();
        string[] input = File.ReadAllLines(name);
        List<string> data = new List<string>(input);
        data.Insert(0, "<html><p>");

        for (int i = 0; i < input.Length; i++)
        {
            if(input[i].Trim() =="")
            {
                data[i] = "</p><p>";
            }
        }

        data.Add("</p></html>");
        File.WriteAllLines(name +".html",data.ToArray());
        Console.WriteLine("Simple HTML generated");
    }
}
