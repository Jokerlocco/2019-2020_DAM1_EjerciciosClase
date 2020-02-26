// Pablo Vigara Fernandez

// Text file to simple HTML
// Version 4: ReadAllLines + WriteAllLines

using System;
using System.IO;

public class TxtToUpper4
{
    static void Main()
    {
        Console.Write("File: ");
        string path = Console.ReadLine();

        string[] input = File.ReadAllLines(path);
        string[] output = new string[input.Length + 2];
        output[0] = "<html><p>";

        for (int i = 0; i < input.Length; i++)
        {
            if (input[i].Trim().Length != 0)
                output[i+1] = input[i];
            else
                output[i+1] = "</p><p>";
        }
        output[output.Length-1] = "</p></html>";

        File.WriteAllLines(path + ".html", output);

        Console.WriteLine("HTML created successfully");
    }
} 
