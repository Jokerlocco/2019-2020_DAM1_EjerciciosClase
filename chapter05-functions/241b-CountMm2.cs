// Pablo Vigara Fernández

using System;

class Count
{
    static void CountMm(string text, ref int upper, ref int lower)
    {
        upper = 0;
        lower = 0;
        foreach (char x in text)
        {
            if ( x >= 'A' && x <= 'Z' )
                upper++;
            else if ( x >= 'a' && x <= 'z' )
                lower++;
        }
    }
    
    static void Main ()
    {
        int upper = 0, lower = 0;
        string text = Console.ReadLine();
        CountMm(text, ref upper, ref lower);
        Console.WriteLine("Uppercase: " + upper);
        Console.WriteLine("Lowercase: " + lower);
        
    }
}
