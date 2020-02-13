using System;
using System.Collections.Generic;
using System.IO;

class InvertFile
{
    static void Main()
    {
        string[] data = File.ReadAllLines("words.txt");

        string search = "";
        while (true)
        {
            char letter = Console.ReadKey().KeyChar;
            search += letter;
            FindAndDisplay(data, search);
            
            Console.WriteLine();
            Console.Write(search);
        }
    }

    private static void FindAndDisplay(string[] data, string s)
    {
        Console.Clear();
        int amountFound = 0;
        for (int i = 0; i < data.Length; i++)
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
