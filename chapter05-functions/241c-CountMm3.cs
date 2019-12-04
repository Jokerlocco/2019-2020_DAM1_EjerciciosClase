using System;

class Count
{
    static void CountMm(string text, out int upper, out int lower)
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
        int u, l;
        string text = Console.ReadLine();
        CountMm(text, out u, out l);
        Console.WriteLine("Uppercase: " + u);
        Console.WriteLine("Lowercase: " + l);
        
    }
}
