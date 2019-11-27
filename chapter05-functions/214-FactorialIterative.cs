using System;

class IterativeFactorial
{
    static long Factorial(int num)
    {
        long total = 1;
        
        for (int i = 1; i <= num; i++)
        {
            total *= i;
        }
        return total;
    }

    static void Main()
    {
        Console.WriteLine( Factorial(16) );
    }
}
