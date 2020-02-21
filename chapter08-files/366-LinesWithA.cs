// Gonzalo Arques

using System;
using System.IO;

class LinesWithA
{
    static void Main()
    {
        string[] fileData;

        Console.Write("Enter the file name: ");
        string fileName = Console.ReadLine();

        if ( !File.Exists(fileName) )
        {
            Console.WriteLine("File does not exist");
        }
        else
        {
            fileData = File.ReadAllLines(fileName);

            for (int lineNum = 0; lineNum < fileData.Length; lineNum++)
            {
                if (fileData[lineNum].StartsWith("A"))
                {
                    Console.WriteLine(fileData[lineNum]);
                }
            }
        }
    }
}
