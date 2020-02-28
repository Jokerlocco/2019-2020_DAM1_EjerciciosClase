// Count lines, words, characters

using System.IO;
using System;

class WordCount
{
    static void Main(string[] args)
    {
        Console.Write("File name? ");
        string name = Console.ReadLine();
        if (File.Exists(name))
        {
            StreamReader file = new StreamReader(name);
            int amountOfLines = 0;
            int amountOfWords = 0;
            int amountOfCharacters = 0;
            
            string line = file.ReadLine();
            
            while(line != null)
            {
                amountOfLines++;                
                amountOfCharacters += line.Length;
                string[] parts = line.Split();
                amountOfWords += parts.Length;
                
                line = file.ReadLine();
            }
            
            file.Close();
            
            Console.WriteLine("Lines:" + amountOfLines);
            Console.WriteLine("Words:" + amountOfWords);
            Console.WriteLine("Characters:" + amountOfCharacters);
        }
    }
}
