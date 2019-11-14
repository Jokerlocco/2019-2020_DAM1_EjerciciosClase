using System;

class TriangleOfName3
{
    static void Main()
    {
        Console.Write("Text: ");
        string name = Console.ReadLine();
        
        string fragment = "";
        for (int i = 0; i < name.Length; i++)
        {
            fragment += name[i];
            Console.WriteLine(fragment);
        }
    
    }
}
