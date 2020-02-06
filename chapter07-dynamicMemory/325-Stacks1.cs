// Contact with Stack

using System;
using System.Collections;

class Stacks1
{
    static void Main()
    {
        Stack myStack = new Stack();
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
