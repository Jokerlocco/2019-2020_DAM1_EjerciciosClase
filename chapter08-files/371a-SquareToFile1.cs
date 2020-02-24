//Daniel García

using System;
using System.IO;

class Square
{
    static void Main()
    {
        StreamWriter file = new StreamWriter("square.txt");

        Console.Write("Enter the side of the square: ");
        int side = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < side; i++)
        {
            for (int j = 0; j < side; j++)
            {
                file.Write("*");
            }
            file.WriteLine();
        }
        file.Close();
    }
}
