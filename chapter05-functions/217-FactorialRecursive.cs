using System;

class RecursiveFactorial
{
    static long Factorial(int num)
    {
        // Base case
        if (num == 1)
            return 1;
        else
        // General case
            return num * Factorial ( num - 1 );
    }

    static void Main()
    {
        Console.WriteLine( Factorial(16) );
    }
}
