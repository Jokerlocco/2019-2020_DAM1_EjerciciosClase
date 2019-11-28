// Function IsPrime
// First approach, slow

using System;

class Prime1
{
    
    static bool IsPrime(long number)
    {
        int dividers = 0;
        for (int i = 1; i <= number; i++)
        {
            if(number % i == 0)
                dividers++;
        }
        return dividers == 2;
    }

    
    static void Main()
    {
        Console.Write( IsPrime(17) );
    }
}
