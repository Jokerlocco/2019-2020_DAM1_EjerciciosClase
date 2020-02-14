//Jose Valera 1ºDAM

using System;
using System.Collections.Generic;

class StackOfInt
{
    private List<int> Lista;
    public int Count { get {return Lista.Count;}  }

    public StackOfInt()
    {
        Lista = new List<int>();
    }

    public StackOfInt(int[] array)
        : this()
    {
        for(int i = 0; i < array.Length; i ++)
        {
            this.Push(array[i]);
        }
    }

    public int Pop()
    {
        int num = Lista[Lista.Count - 1];
        Lista.RemoveAt(Lista.Count - 1);
        return num;
    }

    public void Push(int num)
    {
        Lista.Add(num);
    }
}

class StackOfIntExample
{
    static void Main()
    {
        StackOfInt pilica = new StackOfInt();

        pilica.Push(1);
        pilica.Push(2);
        pilica.Push(3);
        pilica.Push(4);
        pilica.Push(5);

        Console.WriteLine("Cantidad Ini. : " + pilica.Count);
        Console.WriteLine(pilica.Pop());
        Console.WriteLine(pilica.Pop());
        Console.WriteLine(pilica.Pop());
        Console.WriteLine(pilica.Pop());
        Console.WriteLine(pilica.Pop());
        Console.WriteLine("Cantidad Fin : " + pilica.Count);

        Console.WriteLine();

        int[] enteros = { 1, 2, 3, 4, 5 };
        StackOfInt pilica2 = new StackOfInt(enteros);

        Console.WriteLine("Cantidad Ini. : " + pilica2.Count);
        Console.WriteLine(pilica2.Pop());
        Console.WriteLine(pilica2.Pop());
        Console.WriteLine(pilica2.Pop());
        Console.WriteLine(pilica2.Pop());
        Console.WriteLine(pilica2.Pop());
        Console.WriteLine("Cantidad Fin : " + pilica2.Count);
    }
}
