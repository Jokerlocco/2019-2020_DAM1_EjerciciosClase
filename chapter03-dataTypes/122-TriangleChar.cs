//Ruth Martínez Iborra
//triangulo a la derecha

using System;

class Triangulo
{
    static void Main()                                                         
    {
        long size, spaces, symbols;
        char symbol;

        Console.Write("Char? ");
        symbol = Convert.ToChar(Console.ReadLine());

        Console.Write("Size? ");
        size = Convert.ToInt64(Console.ReadLine());

        spaces = 0;
        symbols = size;
        
        for (long row = 1; row <= size; row++)
        {
            for (long space = 1; space <= spaces; space++)
            {
                Console.Write(" ");
            }
            for (long c = 1; c <= symbols; c++)
            {
                Console.Write(symbol);
            }
            Console.WriteLine();

            symbols--;
            spaces++;
        }
    }
}

