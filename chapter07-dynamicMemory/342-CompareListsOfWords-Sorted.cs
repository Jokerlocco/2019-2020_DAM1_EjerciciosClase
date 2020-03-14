using System;
using System.Collections.Generic;
using System.IO;

class InvertFile
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
            if (data1[i].Length > 0)
                if (data1[i][0] != letter)
                {
                    letter = data1[i][0];
                    Console.Write(letter);
                }
            
            for (int j = 0; j < data2.Count; j++)
            {
                if (data1[i] == data2[j])
                    repeated++;
                else if (data1[i].CompareTo(data2[j]) < 0)
                {
                    //Console.WriteLine(data1[i]+ "->"+ data2[j]);
                    break;
                }
            }
        }
        Console.WriteLine("Repeated: " + repeated);
        Console.WriteLine(  DateTime.Now - start) ;
    }
}
