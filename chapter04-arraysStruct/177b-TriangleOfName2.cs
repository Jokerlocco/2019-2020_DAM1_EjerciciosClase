//Daniel Contreras

using System;

class TriangleOfName2
{
    static void Main()
    {
        Console.Write("Text: ");
        string name = Console.ReadLine();
        
        string fragment = "";
        int len = name.Length;
        
        for (int i = 0; i < len; i++)
        {
            fragment += name.Substring(i,1);
            Console.WriteLine(fragment);
        }
    
    }
}
