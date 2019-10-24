// Jose Valera + Daniel García

using System;

class Foreach
{
    static void Main()
    {
        string name;
        
        Console.Write("Enter your name: ");
        name = Console.ReadLine();
        
        foreach (char c in name)
        {
            Console.Write(c + " ");
        }
        Console.WriteLine();
    }
}
