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

        IEnumerator<int> myEnumerator = myStack.GetEnumerator();
        while (myEnumerator.MoveNext())
            Console.WriteLine("{0}", myEnumerator.Current);
        Console.WriteLine( myStack.Pop() );
    }
}

