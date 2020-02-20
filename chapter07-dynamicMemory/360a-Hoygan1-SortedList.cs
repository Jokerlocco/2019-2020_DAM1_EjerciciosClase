//Abraham García

using System;
using System.Collections.Generic;

class Hoygan1 
{
    static void Main()
    {
        SortedList<String, String> s = new SortedList<string, string>();

        s["hoygan"] = "perdonad";
        s["alluda"] = "ayuda";
        s["porfabor"] = "por favor";
        s["pinchewey"] = "compañero";

        string sentence = Console.ReadLine();
        string[] sentenceSplit = sentence.Split();
        sentence = "";

        for (int i = 0; i < sentenceSplit.Length; i++)
        {
            if (s.ContainsKey(sentenceSplit[i]))
                sentence += s[ sentenceSplit[i] ] + " ";
            else
                sentence += sentenceSplit[i] + " ";
        }

        Console.WriteLine(sentence);

    }
}

   
