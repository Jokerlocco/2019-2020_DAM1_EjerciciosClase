// Daniel García
// Power

using System;

class PowerOfANumber
{
    static int Power( int n, uint exp )
    {
        int result = 1;
        
        for (int i = 0; i < exp; i++)
        {
            result *= n;
        }
        
        return result;
    }
    
    static void Main()
    {
        int a;
        uint b;
        
        Console.Write("Base: ");
        a = Convert.ToInt32( Console.ReadLine() );
        Console.Write("Power: ");
        b = Convert.ToUInt32( Console.ReadLine() );
        
        Console.Write(Power(a, b));
    }
}
