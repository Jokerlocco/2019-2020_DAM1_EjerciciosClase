//Francisco jiménez velasco

using System;

class BinaryOperators
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int a = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Enter another number: ");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(Convert.ToString(a, 2));
        Console.WriteLine(Convert.ToString(b, 2));
        Console.WriteLine(" OR: " + Convert.ToString( a | b , 2));
        Console.WriteLine("AND: " + Convert.ToString( a & b , 2));
        Console.WriteLine("XOR: " + Convert.ToString( a ^ b , 2));

        Console.WriteLine("NOT: " + Convert.ToString( ~ a, 2));
        Console.WriteLine(">>: " + Convert.ToString( a >> 1, 2));
        Console.WriteLine("<<: " + Convert.ToString( a << 1, 2));
    }
}
