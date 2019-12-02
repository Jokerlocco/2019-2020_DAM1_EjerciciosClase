// Araceli Yáñez Muñoz
using System;

class FunctionCountVS
{
    static void CountVS(string text, ref int vowel, ref int spc)
    {
        vowel = 0;
        spc = 0;
        foreach (char p in text.ToUpper())
        {
            if (p == ' ')
                spc++;
            if (p == 'A' || p == 'E' || p == 'I' || p == 'O' || p == 'U')
                vowel++;
        }
    }

    static void Main()
    {
        int vowels = 0;
        int spaces = 0;
        CountVS("This is a sentence", ref vowels, ref spaces);
        Console.WriteLine("vow: " + vowels + " spc: " + spaces);
    }
}
