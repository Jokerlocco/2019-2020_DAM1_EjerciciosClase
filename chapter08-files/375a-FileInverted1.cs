// Pablo Vigara Fernandez

using System;
using System.IO;

class FileInverted1
{
    static void Main()
    {
        Console.Write("File name: ");
        string path = Console.ReadLine();
        string[] text = File.ReadAllLines(path);
        Array.Reverse(text);

        for (int i = 0; i < text.Length; i++)
        {
            char[] word = text[i].ToCharArray();
            Array.Reverse(word);

            for (int j = 0; j < word.Length; j++)
            {
                Console.Write(word[j]);
            }
            Console.WriteLine();
        }
    }
} 
