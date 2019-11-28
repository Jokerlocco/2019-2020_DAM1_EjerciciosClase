// Ruth Martínez
// Power, recursive

using System;

class PowerOfANumber
{
    static int Power(int n, uint exp)
    {
        // Base case
        if (exp == 0)
        {
            return 1;
        }
        // General case
        else
        {
            return n * Power(n, exp - 1);
        }
    }

    static void Main()
    {
        int a;
        uint b;

        Console.Write("Base: ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Power: ");
        b = Convert.ToUInt32(Console.ReadLine());

        Console.Write(Power(a, b));
    }
}
