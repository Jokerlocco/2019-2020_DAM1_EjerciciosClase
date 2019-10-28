//Pablo Miguel Climent Gonzálvez
using System;
class Trapecio
{
    static void Main()
    {
        byte width,height;
        char symbol;

        Console.Write("Enter the width: ");
        width=Convert.ToByte(Console.ReadLine());

        Console.Write("Enter the height: ");
        height=Convert.ToByte(Console.ReadLine());

        Console.Write("Enter the char: ");
        symbol=Convert.ToChar(Console.ReadLine());

        for (int i=1 ; i<=height ; i++)
        {
            for (int j=1 ; j <= (height-i) ; j++)
            {
                Console.Write(" ");
            }
            for (int k=1 ; k <= (width + 2*(i-1)) ; k++)
            {
                Console.Write(symbol);
            }
            Console.WriteLine();
        }
    }
}
