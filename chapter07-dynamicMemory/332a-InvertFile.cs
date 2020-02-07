using System;
using System.Collections.Generic;
using System.IO;

class InvertFile
{
    static void Main()
    {
        Console.Write("File to invert? ");
        string[] readText = File.ReadAllLines(
            Console.ReadLine());
        Stack<string> data = new Stack<string>(readText);
        Console.Write("Output name? ");
        File.WriteAllLines(Console.ReadLine(), data.ToArray() );
    }
}
