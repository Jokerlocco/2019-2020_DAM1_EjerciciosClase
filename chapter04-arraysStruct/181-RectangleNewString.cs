//Alberto Girón Serna

using System;
class RectangleNewString
{
    static void Main ()
    {
        int height, width;
        char c;
        Console.WriteLine("Width? ");
        width = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Height? ");
        height = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Symbol? ");
        c = Convert.ToChar(Console.ReadLine());
        
        string line = new string (c, width);
        for (int i = 0; i < height; i++)
            Console.WriteLine(line);
    }
}
