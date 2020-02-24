//Lautaro Álvaro Fernández

using System;
using System.IO;

class Reverse
{
    static void Main()
    {
        Console.Write("File name: ");
        string[] file = File.ReadAllLines(Console.ReadLine());
        Console.WriteLine();
        
        for ( int i = file.Length-1; i >= 0; i-- )
        {
            for ( int j = file[i].Length-1; j >= 0; j-- )
            {
                Console.Write(file[i][j]);
            }
            Console.WriteLine();
        }
    }
}
