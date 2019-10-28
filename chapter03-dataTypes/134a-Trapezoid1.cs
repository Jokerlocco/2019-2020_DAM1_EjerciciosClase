//Pablo Conde
//Dibuja un trapecio

using System;

class Trapecio
{
    static void Main()
    {
        int width, height;
        char symbol;
        
        Console.Write("Enter the width: ");
        width = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the height: ");
        height = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the char: ");
        symbol = Convert.ToChar(Console.ReadLine());
        
        int spaces = height-1;
        
        for ( int i = 0; i < height; i++)
        {
            for (int j = 1; j <= spaces; j++)
            {
                Console.Write(" ");
            }
            for (int k = 1; k <= width; k++)
            {
                Console.Write(symbol);
            }
           
            Console.WriteLine();
            width += 2;
            spaces--;
        }
      
    }
}
