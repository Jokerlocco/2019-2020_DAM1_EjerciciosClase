//Joel Martinez

using System;

class TriangleOfName
{   
    static void Main()
    {
        string name;
        
        Console.Write("Enter your name: ");
        name = Console.ReadLine();
        
        for (int x = 1; x <= name.Length; x++)
        {
            Console.WriteLine(name.Substring(0,x));
        }
    }
}
