// Comparing two (big) lists of words using List<string>
// words1.txt: 354.985 words
// words2.txt: 235.886 words
// Answer: 210.651
// Time taken on Pentium G4560: 07:35.89 min

using System;
using System.Collections.Generic;
using System.IO;

class CompareTwoLists1
{
    static void Main()
    {
        List<string> data1 = new List<string>(
            File.ReadAllLines("words.txt"));
        List<string> data2 = new List<string>(
            File.ReadAllLines("words2.txt"));

        DateTime start = DateTime.Now;
        int repeated = 0;
        char letter = '-';
        for (int i = 0; i < data1.Count; i++)
        {
            // Let's show the first letter
            if (data1[i].Length > 0)
                if (data1[i][0] != letter)
                {
                    letter = data1[i][0];
                    Console.Write(letter);
                }
            // And process all the words
            for (int j = 0; j < data2.Count; j++)
            {
                if (data1[i] == data2[j])
                    repeated++;
            }
        }
        Console.WriteLine("Repeated: " + repeated);
        Console.WriteLine(  DateTime.Now - start) ;
    }
}
