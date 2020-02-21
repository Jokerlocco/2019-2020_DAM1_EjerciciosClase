//Jose Valera 1ºDAM

using System;
using System.Collections;
using System.IO;

class LinesWithA 
{
    static void Main()
    {
        Console.Write("File Name: ");
        string fileName = Console.ReadLine();

        string[] content = File.ReadAllText(fileName).Split('\n');
        int count = 0;

        for (int i = 0; i < content.Length; i++)
            if (content[i].ToUpper().StartsWith("A"))
                count++;

        Console.WriteLine("Lines starting with A: " + count);
    }
}
