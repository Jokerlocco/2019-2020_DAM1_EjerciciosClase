using System;

// Trying to swap two variables... the right way
// (parameters passed by reference)

class RefOk
{
    static void Swap(ref int x, ref int y)
    {
        int aux = x;
        x = y;
        y = aux;
    }

    static void Main()
    {
        int a = 5, b = 3;
        Swap(ref a, ref b);
        Console.WriteLine("{0} {1}", a, b);
    }
}
