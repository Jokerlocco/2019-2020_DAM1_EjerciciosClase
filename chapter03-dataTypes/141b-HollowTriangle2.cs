//Pablo Miguel Climent Gonzálvez
using System;
class HollowTriangle
{
    static void Main()
    {
        uint width;
        char c;

        Console.Write("Size? ");
        width = Convert.ToUInt32(Console.ReadLine());

        Console.Write("Symbol? ");
        c = Convert.ToChar(Console.ReadLine());

        for (int i=1 ; i<=width ; i++)
            Console.Write(c);
        Console.WriteLine();
        for (int i=1 ; i<width-1 ; i++)
        {
            for (int j=1 ; j<=i ; j++)
                Console.Write(" ");
            Console.Write(c);
            for (int j=1 ; j<=(width-i-2) ; j++)
                Console.Write(" ");
            Console.Write(c);
            Console.WriteLine();
        }
        for (int i=1 ; i<=width-1 ; i++)
            Console.Write(" ");
        Console.Write(c);
    }
}
