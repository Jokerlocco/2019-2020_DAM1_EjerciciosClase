// Pablo Conde
// Hex table from 0 to 0xFF

using System;

class HexTable
{
    static void Main()
    {
        
        for ( int i = 0; i < 256; i++)
        {
            // Decimal
            if (i % 16 == 0)
                Console.Write(i + ": ");
            
            // Hexadecimal
            if (i < 16)
                Console.Write(" 0" + i.ToString("x") + " ");
            else
                Console.Write(" " + i.ToString("x") + " ");
            
            // New line
            if (i % 16 == 15)
                Console.WriteLine();
        }
    }
}
