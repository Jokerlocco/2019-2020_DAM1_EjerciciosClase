/*
DrawParallelogram(10, 4, '*'); =>

**********
 *        *
  *        *
   ********** 

*/

using System;

class Parallelogram
{
    static void DrawParallelogram(byte width, byte height, char symbol)
    {
        // First line
        Console.WriteLine(new string (symbol, width));

        // Middle lines
        string spaces = new string(' ', width - 2);
        for (int i = 1; i < height-1; i++)
        {
            Console.WriteLine(new string (' ', i) + 
                symbol + spaces + symbol);
        }

        // Last line
        Console.WriteLine(new string (' ', height-1) 
            + new string (symbol, width));
    }


    static void Main(string[] args)
    {
        DrawParallelogram(10, 4, '*');
    }
}
