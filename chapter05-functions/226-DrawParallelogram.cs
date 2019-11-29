//Sergio Gumpert

using System;

class FunctionDrawParallelogram
{
    static void DrawParallelogram(int width , int height, char ch)
    {
        int spaces = 0;
        
        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < spaces; j++)
                Console.Write(" ");
            for (int x = 0; x < width; x++)
                Console.Write(ch);
            Console.WriteLine("");
            spaces++;
        }
    }

    static void Main()
    {
        DrawParallelogram(10,4,'*');
    }
}
