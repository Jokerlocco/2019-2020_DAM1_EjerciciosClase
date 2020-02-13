// Pablo Vigara Fernandez

using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

class PruebaDeEncriptador
{
    static void Main()
    {
        Stack<int> myStack = new Stack<int>();

        string num;
        do
        {
            Console.Write("Number: ");
            num = Console.ReadLine();

            if (num != "")
            {
                myStack.Push(Convert.ToInt32(num));
            }
        }
        while (num != "");

        foreach(int i in myStack)
        {
            Console.WriteLine("{0}", i);
        }
        Console.WriteLine( myStack.Pop() );
    }
}

