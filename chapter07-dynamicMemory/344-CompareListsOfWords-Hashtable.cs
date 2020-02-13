using System;
using System.Collections.Generic;
using System.IO;

class InvertFile
{
    static void Main()
    {
        string[] file1 = File.ReadAllLines("words.txt");
        string[] file2 = File.ReadAllLines("words2.txt");

        Dictionary<string, bool> data2 = new Dictionary<string, bool>(250000);
        for (int i = 0; i < file2.Length; i++)
            if (!data2.ContainsKey(file2[i]))
            {
                data2[ file2[i] ] = true;
            }

        DateTime start = DateTime.Now;
        int repeated = 0;
        for (int i = 0; i < file1.Length; i++)
        {
            if (data2.ContainsKey( file1[i] ))
                    repeated++;
        }
        Console.WriteLine("Repeated: " + repeated);
        Console.WriteLine(  DateTime.Now - start) ;
    }
}
