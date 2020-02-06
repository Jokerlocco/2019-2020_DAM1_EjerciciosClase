// Stack + generic

using System;
using System.Collections.Generic;

class Stacks2
{
    static void Main()
    {
        Stack<int> myStack = new Stack<int>();
        for (int i = 0; i < 5; i++)
        {
            Console.Write("Enter data "+(i+1)+ ": ");
            int data = Convert.ToInt32( Console.ReadLine() );

            myStack.Push(data);
        }

        while (myStack.Count > 0)
        {
            Console.WriteLine( myStack.Pop() );
        }
    }
}
