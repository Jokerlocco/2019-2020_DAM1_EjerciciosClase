//Patricia López Navarro
using System;
using System.IO;

class ReadAllFile
{
    static void Main()
    {
        Console.Write("Enter file name: ");
        string fileName = Console.ReadLine();
        StreamReader inputFile;
        inputFile = File.OpenText(fileName);
        string line;
        do
        {
            line = inputFile.ReadLine();
            if (line != null)
            {
                if (line.Trim().Length != 0)
                {
                    Console.WriteLine(line);
                }
            }
        }
        while (line != null);
        inputFile.Close();
    }
}
