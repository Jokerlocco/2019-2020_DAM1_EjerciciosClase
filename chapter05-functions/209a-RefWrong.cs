using System;

// Trying to swap two variables... the wrong way
// (parameters passed by value)

class RefWrong
{
    static void Swap(int x, int y)
    {
        int aux = x;
        x = y;
        y = aux;
    }

    static void Main()
    {
        int a = 5, b = 3;
        Swap(a, b);
        Console.WriteLine("{0} {1}", a, b);
    }
}
