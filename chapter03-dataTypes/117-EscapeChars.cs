//Hugo Gonzalez

using System;

class EscapeChars
{
    static void Main()
    {
        char x, y, z;
        Console.Write("Enter a symbol: ");
        x = Convert.ToChar(Console.ReadLine());
        Console.Write("Enter another symbol: ");
        y = Convert.ToChar(Console.ReadLine());
        Console.Write("Enter the last symbol: ");
        z = Convert.ToChar(Console.ReadLine());

        Console.Write("{0}\n\"{1}{2}\"", z, y, x);
    }
}
