using System;
using System.Collections.Generic;
using System.IO;

class InvertFile
{
    static void Main()
    {
        string[] data = File.ReadAllLines("words.txt");

        Dictionary<char, int> index = new Dictionary<char, int>();
        char currentLetter = '-';
        for (int i = 0; i < data.Length; i++)
        {
            if (data[i].Length > 0)
                if (data[i][0] != currentLetter)
                {
                    currentLetter = data[i][0];
                    index.Add(currentLetter, i);
                }
        }

        string search = "";
        char letter = Console.ReadKey().KeyChar;
        int start = index[letter];
        search += letter;

        while (true)
        {
            FindAndDisplay(data, search, start);
            letter = Console.ReadKey().KeyChar;
            search += letter;
        }
    }

    private static void FindAndDisplay(
        string[] data, string s, int startPos)
    {
        Console.Clear();
        int amountFound = 0;
        for (int i = startPos; i < data.Length; i++)
        {
            if (data[i].StartsWith(s))
            {
                Console.WriteLine(data[i]);
                amountFound++;
                if (amountFound >= 7)
                    break;
            }
        }
    }
}
