//Saúl Cánovas Navarro

using System;

class HollowTriangle
{
    static void Main()
    {
        int size, symbols, spaces, rowMax;
        char c;

        Console.Write("Size? ");
        size = Convert.ToInt32(Console.ReadLine());
        Console.Write("Symbol? ");
        c = Convert.ToChar(Console.ReadLine());

        symbols = size;
        spaces = 0;
        rowMax = size;

        for (int row = 1; row <= rowMax; row++)
        {
            for (int space = 1; space <= spaces; space++)
            {
                Console.Write(" ");
            }
            for (int symbol = 1; symbol <= symbols; symbol++)
            {
                if( row == 1 || row == rowMax || symbol == 1 || symbol == symbols)
                {
                    Console.Write("{0}", c);
                }
                else
                {
                    Console.Write(" ");
                }
                
            }
            spaces++;
            symbols--;
            Console.WriteLine();
        }
    }
}
