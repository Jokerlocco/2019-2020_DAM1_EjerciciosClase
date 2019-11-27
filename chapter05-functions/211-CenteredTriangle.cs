using System;

class CenteredTriangle
{
    static void WriteCenteredTriangle(char c, int width)
    {
        int amountOfSpaces = 40 - width / 2;
        int amountOfSymbols = width;
        
        while(amountOfSymbols > 0)
        {
            
            string spaces = new string(' ', amountOfSpaces);
            string symbols = new string(c, amountOfSymbols);
            Console.WriteLine(spaces + symbols);
            
            amountOfSpaces++;
            amountOfSymbols -= 2;
        }
    }
    
    static void Main()
    {
        WriteCenteredTriangle('#', 9);
    }
}
