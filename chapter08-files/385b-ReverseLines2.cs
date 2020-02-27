//Kiko
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
            StreamWriter output = File.CreateText(path 
                + "reversed.txt");
            for(int i = input.Length-1; i>=0; i--)
            {
                output.WriteLine(input[i]);
            }
            output.Close();
        }
    }
}
