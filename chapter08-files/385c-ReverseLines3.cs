using System;
using System.IO;

class Reversed
{
    static void Main()
    {
        Console.WriteLine("Path : ");
        string path = Console.ReadLine();
        if (!File.Exists(path))
        {
            Console.WriteLine("File not found");
        }
        else
        {
            string[] input = File.ReadAllLines(path);
            Array.Reverse(input);
            File.WriteAllLines(path + "reversed.txt", input);
        }
    }
}
