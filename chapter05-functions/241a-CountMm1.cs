//Lautaro Álvaro Fernández

using System;

class Count
{
    static void CountMm( string s, ref int upper, ref int lower )
    {
        upper = 0;
        lower = 0;
        
        for ( int i = 0; i < s.Length; i++ )
        {
            if ( s[i] >= 'A' && s[i] <= 'Z' )
                upper++;
            else if ( s[i] >= 'a' && s[i] <= 'z' )
                lower++;
        }
    }
    
    static void Main()
    {
        int upper = 0, lower = 0;
        CountMm("This is An Example", ref upper, ref lower);
        Console.WriteLine("Uppercase: " + upper 
            + ", lowercase: " + lower);
    }
}
