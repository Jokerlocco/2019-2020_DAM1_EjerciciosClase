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
            string[] lines = File.ReadAllLines(name);

            int amountOfLines = lines.Length;
            int amountOfWords = 0;
            int amountOfCharacters = 0;
            foreach(string line in lines)
            {      
                amountOfCharacters += line.Length;
                string[] parts = line.Split();
                amountOfWords += parts.Length;
            }
            
            Console.WriteLine("Lines:" + amountOfLines);
            Console.WriteLine("Words:" + amountOfWords);
            Console.WriteLine("Characters:" + amountOfCharacters);
        }
    }
}
