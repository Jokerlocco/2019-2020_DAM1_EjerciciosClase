//Jose Valera 1ºDAM

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

class Square
{
    static void Main()
    {
        StreamWriter fichero = File.CreateText("square.txt");

        Console.Write("Size? ");
        int size = Convert.ToInt32(Console.ReadLine());

        for (int rows = 0; rows < size; rows++)
            fichero.WriteLine(new String('*', size));

        fichero.Close();
    }
}
