//Jose Valera 1ºDAM

// Text file to simple HTML
// Version 4: ReadAllLines + WriteAllLines

using System;
using System.IO;

public class TxtToUpper4
{
    static void Main()
    {
        Console.Write("File Name: ");
        string url = Console.ReadLine();
        string[] content = File.ReadAllLines(url);
        
        content[0] = "<html><p>" + content[0];
        for(int i = 1; i < content.Length; i ++)
        {
            if(content[i].Trim() == "")
                content[i] = "</p><p>";
        }
        content[content.Length - 1] += "</p></html>";
        
        File.WriteAllLines(url + ".html", content);
    }
}
